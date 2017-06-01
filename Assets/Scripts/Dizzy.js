import UnityStandardAssets.ImageEffects;

#pragma strict

public var mBlur : MotionBlur;

public var sanityScript : InsanityManager;

function Start()
{
	mBlur = gameObject.GetComponent(MotionBlur);
	sanityScript = gameObject.GetComponent(InsanityManager);
	mBlur.enabled = false;
}

function Update()
{
	if(sanityScript.currentSanity >= 20)
	{
		mBlur.enabled = true;
		mBlur.blurAmount = 0.2f;
	}
	
	if(sanityScript.currentSanity >= 40)
	{
		mBlur.enabled = true;
		mBlur.blurAmount = 0.4f;
	}
	
	if(sanityScript.currentSanity >= 60)
	{
		mBlur.enabled = true;
		mBlur.blurAmount = 0.6f;
	}
	
	if(sanityScript.currentSanity >= 80)
	{
		mBlur.enabled = true;
		mBlur.blurAmount = 0.85f;
	}
	
	if(sanityScript.currentSanity >= 90)
	{
		mBlur.enabled = true;
		mBlur.blurAmount = 0.99f;
	}
}