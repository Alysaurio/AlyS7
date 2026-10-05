// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "AlyS7GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AAlyS7GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AAlyS7GameMode();
};



