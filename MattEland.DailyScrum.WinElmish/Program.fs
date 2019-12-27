open System
open Elmish.WPF
open MattEland.DailyScrum.WinElmish.Views

type Model = {
  Turns: int
}

let init (): Model = {
  Turns = 0
}

type Msg = 
  | NextTurn
  | Restart

let update (msg: Msg) (model: Model) : Model =
  match msg with 
  | NextTurn -> {model with Turns = model.Turns + 1}
  | Restart -> init()

let bindings () : Binding<Model, Msg> list = [
  "AppTitle" |> Binding.oneWay (fun _ -> "Daily Scrum by Matt Eland")
  "NextTurnCommand" |> Binding.cmd NextTurn
  "TurnNumber" |> Binding.oneWay (fun m -> "Turn " + m.Turns.ToString())
]

[<EntryPoint; STAThread>]
let main argv =
  Program.mkSimpleWpf init update bindings
  |> Program.runWindow (MainWindow())