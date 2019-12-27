open System
open Elmish.WPF
open MattEland.DailyScrum.WinElmish.Model
open MattEland.DailyScrum.WinElmish.Views
open MattEland.DailyScrum.WinElmish.ElmProcessor

[<EntryPoint; STAThread>]
let main _ =
  Program.mkSimpleWpf init update bindings
  |> Program.runWindow (MainWindow())