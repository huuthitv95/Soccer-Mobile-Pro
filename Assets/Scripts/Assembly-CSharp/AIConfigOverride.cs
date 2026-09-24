public struct AIConfigOverride
{
    public float difficulty;
    public float teammate_difficulty;
    public float match_duration;
    public AIConfigOverride(float difficulty, float teammate_difficulty, float match_duration = 6f)
    {
        this.difficulty = 0f;
        this.teammate_difficulty = 0f;
        this.match_duration = 0f;
    }

    public void OverrideTo(AIConfig config)
    {
    }
}