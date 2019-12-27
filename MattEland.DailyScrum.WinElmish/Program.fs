open System
open Elmish
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
  model

let bindings () : Binding<Model, Msg> list = [
  //"CounterValue" |> Binding.oneWay (fun m -> m.Count)
  //"Increment" |> Binding.cmd Increment
  //"Decrement" |> Binding.cmd Decrement
  //"StepSize" |> Binding.twoWay(
//    (fun m -> float m.StepSize),
    //(int >> SetStepSize)
  //)
]

[<EntryPoint; STAThread>]
let main argv =
  Program.mkSimpleWpf init update bindings
  |> Program.runWindow (MainWindow())