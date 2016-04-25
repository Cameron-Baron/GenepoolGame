using UnityEngine;

public static class ParticleSystemExtension
{
	public static void EnableEmission(this ParticleSystem particleSystem, bool enabled)
	{
		var emission = particleSystem.emission;
		emission.enabled = enabled;
	}

	public static float GetEmissionRate(this ParticleSystem particleSystem)
	{
		return particleSystem.emission.rate.constantMax;
	}

	public static void SetEmissionRate(this ParticleSystem particelSystem, float emissionRate)
	{
		var emission = particelSystem.emission;
		var rate = emission.rate;
		rate.constantMax = emissionRate;
		emission.rate = rate;
	}
}
