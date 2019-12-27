module MattEland.DailyScrum.WinElmish.TurnProcessor

open MattEland.DailyScrum.WinElmish.Model

let advanceTurn model =
  {model with Turns = model.Turns + 1}

