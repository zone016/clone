SOLUTION=Clone.sln
PROJECT=Clone.Console/Clone.Console.csproj

DOTNET=dotnet

all: publish

publish:
	$(DOTNET) publish $(PROJECT) \
		-p:PublishAot=true \
		-p:OptimizationPreference=Size \
		-p:StackTraceSupport=false \
		-p:InvariantGlobalization=true \
		-p:UseSystemResourceKeys=true

clean:
	$(DOTNET) clean $(SOLUTION)

test:
	$(DOTNET) test $(SOLUTION)
