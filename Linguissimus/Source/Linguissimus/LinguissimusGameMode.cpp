// Copyright Epic Games, Inc. All Rights Reserved.

#include "LinguissimusGameMode.h"
#include "LinguissimusCharacter.h"
#include "UObject/ConstructorHelpers.h"

ALinguissimusGameMode::ALinguissimusGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
