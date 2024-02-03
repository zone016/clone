$PROJECT = "Clone.Console/Clone.Console.csproj"
$DOTNET = "dotnet"

& $DOTNET publish $PROJECT `
    -p:PublishAot=true `
    -p:OptimizationPreference=Size `
    -p:StackTraceSupport=false `
    -p:InvariantGlobalization=true `
    -p:UseSystemResourceKeys=true
    