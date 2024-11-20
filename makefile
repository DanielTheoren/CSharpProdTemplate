FILE := app

ifdef OS
	BIN  := $(FILE)/bin/Debug/net8.0/$(FILE).exe
else
	BIN  := $(FILE)/bin/Debug/net8.0/$(FILE).bin
endif


default: build run

build: $(FILE)
	dotnet build

run: $(BIN)
	$(BIN)