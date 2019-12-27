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
  "AppTitle" |> Binding.oneWay (fun _ -> "Hello Elmish.WPF")
  //"Increment" |> Binding.cmd Increment
  //"Decrement" |> Binding.cmd Decrement
]

[<EntryPoint; STAThread>]
let main argv =
  Program.mkSimpleWpf init update bindings
  |> Program.runWindow (MainWindow())