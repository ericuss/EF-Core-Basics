
## Create migrations
dotnet ef migrations add InitialBuaAmbulance -c EF.Core.Contexts.Contexts.BuaAmbulanceContext -o ../../Data/EF.Core.Contexts/Migrations/BuaAmbulance -p ../../Data/EF.Core.Contexts/

## Apply migrations
dotnet ef database update -c EF.Core.Contexts.Contexts.BuaAmbulanceContext -p ../../Data/EF.Core.Contexts/  