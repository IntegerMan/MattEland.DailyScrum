module MattEland.DailyScrum.WinElmish.Model

type ServerRole = 
  | Development
  | QA
  | Staging
  | Production

type Server = {
  Id: int
  Name: string
  Role: ServerRole
}

type Model = {
  Turns: int
  Servers: Server list
}

/// Application default starting state
let init (): Model = {
  Turns = 0
  Servers = [
    {
      Id=1
      Name = "SRV-PROD-1"
      Role = Production
    }
    {
      Id=2
      Name = "SRV-STAGE-1"
      Role = Staging
    }
    {
      Id=3
      Name = "SRV-QA-1"
      Role = QA
    }
  ]
}