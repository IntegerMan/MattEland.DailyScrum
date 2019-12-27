module MattEland.DailyScrum.WinElmish.ElmProcessor

open MattEland.DailyScrum.WinElmish.Model
open MattEland.DailyScrum.WinElmish.TurnProcessor
open Elmish.WPF

type Msg = 
  | NextTurn
  | Restart

let update (msg: Msg) (model: Model) : Model =
  match msg with 
  | NextTurn -> advanceTurn(model)
  | Restart -> init()

let bindings () : Binding<Model, Msg> list = [
  // One-Way Bindings
  "AppTitle" |> Binding.oneWay (fun _ -> "Daily Scrum by Matt Eland")
  "TurnNumber" |> Binding.oneWay (fun m -> "Turn " + m.Turns.ToString())
  "Servers" |> Binding.subModelSeq(
    (fun (m) -> m.Servers),
    (fun (c) -> c.Id),
    (fun () -> [
      "Id" |> Binding.oneWay(fun (_, s) -> s.Id)
      "Name" |> Binding.oneWay(fun (_, s) -> s.Name)
    ])
  )

  // Commands
  "NextTurnCommand" |> Binding.cmd NextTurn
]
