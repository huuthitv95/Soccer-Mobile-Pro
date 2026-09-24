namespace SLLevel
{
    public struct LevelData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.MatchStateEnum MatchState => global::SLLevel.MatchStateEnum.Playing;
        public int MatchStartDelay => 0;
        public bool Novice => false;
        public float PitchHalfW => 0f;
        public float PitchHalfH => 0f;
        public float GoalBase => 0f;
        public float GoalDepth => 0f;
        public float GoalHeight => 0f;
        public float GoalHalfWidth => 0f;
        public float PenaltyAreaHalfW => 0f;
        public float PenaltyAreaH => 0f;
        public float Gravity => 0f;
        public float BallRadius => 0f;
        public float GroundFriction => 0f;
        public global::SLLevel.Vector3? BallPosition => null;
        public float BallMovYaw => 0f;
        public float BallMovPitch => 0f;
        public float BallMovSpeed => 0f;
        public int Team1DatabaseId => 0;
        public int Team2DatabaseId => 0;
        public float Difficulty => 0f;
        public float CameraStartAngle => 0f;
        public float CameraStartHeight => 0f;
        public float CameraStartTan => 0f;
        public float CameraFOV => 0f;
        public float CameraTan => 0f;
        public float CameraY => 0f;
        public bool CameraConstant => false;
        public float FormationOffMinX => 0f;
        public float FormationOffMinY => 0f;
        public float FormationOffMaxX => 0f;
        public float FormationOffMaxY => 0f;
        public float FormationDefMinX => 0f;
        public float FormationDefMinY => 0f;
        public float FormationDefMaxX => 0f;
        public float FormationDefMaxY => 0f;
        public float FormationOffXLength => 0f;
        public float FormationOffYLength => 0f;
        public float FormationOffDCToBall => 0f;
        public float FormationOffDCLineMin => 0f;
        public float FormationOffDCLineMax => 0f;
        public float FormationOffFCLineMin => 0f;
        public float FormationOffFCLineMax => 0f;
        public float FormationOffYFactor => 0f;
        public float FormationDefXLength => 0f;
        public float FormationDefYLength => 0f;
        public float FormationDefYLengthMin => 0f;
        public float FormationDefDCToBall => 0f;
        public float FormationDefDCLineMin => 0f;
        public float FormationDefDCLineMax => 0f;
        public float FormationDefFCLineMin => 0f;
        public float FormationDefFCLineMax => 0f;
        public float FormationDefYFactor => 0f;
        public int OppoManmarkingPlayerNum => 0;
        public int OppoHuntingPlayerNum => 0;
        public float IdealShotDistance => 0f;
        public bool AiAttackingRun => false;
        public bool AiForwardSupport => false;
        public bool AiSupport => false;
        public bool AiOffside => false;
        public bool AiOffsideTrap => false;
        public bool AiInvalidatePassto => false;
        public bool AiPasstoHero => false;
        public bool AiDynamicFormation => false;
        public bool AiNewMarkSupport => false;
        public float AiPassMinimum => 0f;
        public float AiPassWeight => 0f;
        public int AiAllowedToChaseBall => 0;
        public float MaxDefendDistance => 0f;
        public float MinDefendDistance => 0f;
        public int AiVersion => 0;
        public int Team1PlayersLength => 0;
        public int Team2PlayersLength => 0;
        public int HeroId => 0;
        public int Star0Type => 0;
        public int Star0Id => 0;
        public global::SLLevel.Vector3? Star0Position => null;
        public int Star1Type => 0;
        public int Star1Player => 0;
        public global::SLLevel.Vector3? Star1Position => null;
        public global::SLLevel.Vector2? ShootPos => null;
        public float ShootCurve => 0f;
        public float ShootSnapRadius => 0f;
        public float SlMinShotMomentum => 0f;
        public float SlMaxShotMomentum => 0f;
        public global::SLLevel.Vector3? CineCameraPos => null;
        public float CineCameraFOV => 0f;
        public int TrainingToolsLength => 0;
        public int OriScore => 0;
        public int TarScore => 0;
        public int OperatorToolsLength => 0;
        public int BuffToolsLength => 0;
        public global::SLLevel.BallService? BallService => null;
        public int AiGetToBallTimeLimit => 0;
        public bool Woodwork => false;
        public float DeflectCheatoffsetScalar => 0f;
        public int AiExtraReactionTimeMs => 0;
        public float ShootAngleLimit => 0f;
        public global::SLLevel.GolfTarget? GolfTarget => null;
        public int InputCountLimit => 0;

        public static global::SLLevel.LevelData GetRootAsLevelData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.LevelData GetRootAsLevelData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.LevelData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.LevelData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateMatchState(global::SLLevel.MatchStateEnum MatchState)
        {
            return false;
        }

        public bool MutateMatchStartDelay(int MatchStartDelay)
        {
            return false;
        }

        public bool MutateNovice(bool Novice)
        {
            return false;
        }

        public bool MutatePitchHalfW(float pitchHalfW)
        {
            return false;
        }

        public bool MutatePitchHalfH(float pitchHalfH)
        {
            return false;
        }

        public bool MutateGoalBase(float goalBase)
        {
            return false;
        }

        public bool MutateGoalDepth(float goalDepth)
        {
            return false;
        }

        public bool MutateGoalHeight(float goalHeight)
        {
            return false;
        }

        public bool MutateGoalHalfWidth(float goalHalfWidth)
        {
            return false;
        }

        public bool MutatePenaltyAreaHalfW(float penaltyAreaHalfW)
        {
            return false;
        }

        public bool MutatePenaltyAreaH(float penaltyAreaH)
        {
            return false;
        }

        public bool MutateGravity(float gravity)
        {
            return false;
        }

        public bool MutateBallRadius(float ballRadius)
        {
            return false;
        }

        public bool MutateGroundFriction(float groundFriction)
        {
            return false;
        }

        public bool MutateBallMovYaw(float BallMovYaw)
        {
            return false;
        }

        public bool MutateBallMovPitch(float BallMovPitch)
        {
            return false;
        }

        public bool MutateBallMovSpeed(float BallMovSpeed)
        {
            return false;
        }

        public bool MutateTeam1DatabaseId(int Team1DatabaseId)
        {
            return false;
        }

        public bool MutateTeam2DatabaseId(int Team2DatabaseId)
        {
            return false;
        }

        public bool MutateDifficulty(float Difficulty)
        {
            return false;
        }

        public bool MutateCameraStartAngle(float CameraStartAngle)
        {
            return false;
        }

        public bool MutateCameraStartHeight(float CameraStartHeight)
        {
            return false;
        }

        public bool MutateCameraStartTan(float CameraStartTan)
        {
            return false;
        }

        public bool MutateCameraFOV(float CameraFOV)
        {
            return false;
        }

        public bool MutateCameraTan(float CameraTan)
        {
            return false;
        }

        public bool MutateCameraY(float CameraY)
        {
            return false;
        }

        public bool MutateCameraConstant(bool CameraConstant)
        {
            return false;
        }

        public bool MutateFormationOffMinX(float formationOffMinX)
        {
            return false;
        }

        public bool MutateFormationOffMinY(float formationOffMinY)
        {
            return false;
        }

        public bool MutateFormationOffMaxX(float formationOffMaxX)
        {
            return false;
        }

        public bool MutateFormationOffMaxY(float formationOffMaxY)
        {
            return false;
        }

        public bool MutateFormationDefMinX(float formationDefMinX)
        {
            return false;
        }

        public bool MutateFormationDefMinY(float formationDefMinY)
        {
            return false;
        }

        public bool MutateFormationDefMaxX(float formationDefMaxX)
        {
            return false;
        }

        public bool MutateFormationDefMaxY(float formationDefMaxY)
        {
            return false;
        }

        public bool MutateFormationOffXLength(float formationOffXLength)
        {
            return false;
        }

        public bool MutateFormationOffYLength(float formationOffYLength)
        {
            return false;
        }

        public bool MutateFormationOffDCToBall(float formationOffDCToBall)
        {
            return false;
        }

        public bool MutateFormationOffDCLineMin(float formationOffDCLineMin)
        {
            return false;
        }

        public bool MutateFormationOffDCLineMax(float formationOffDCLineMax)
        {
            return false;
        }

        public bool MutateFormationOffFCLineMin(float formationOffFCLineMin)
        {
            return false;
        }

        public bool MutateFormationOffFCLineMax(float formationOffFCLineMax)
        {
            return false;
        }

        public bool MutateFormationOffYFactor(float formationOffYFactor)
        {
            return false;
        }

        public bool MutateFormationDefXLength(float formationDefXLength)
        {
            return false;
        }

        public bool MutateFormationDefYLength(float formationDefYLength)
        {
            return false;
        }

        public bool MutateFormationDefYLengthMin(float formationDefYLengthMin)
        {
            return false;
        }

        public bool MutateFormationDefDCToBall(float formationDefDCToBall)
        {
            return false;
        }

        public bool MutateFormationDefDCLineMin(float formationDefDCLineMin)
        {
            return false;
        }

        public bool MutateFormationDefDCLineMax(float formationDefDCLineMax)
        {
            return false;
        }

        public bool MutateFormationDefFCLineMin(float formationDefFCLineMin)
        {
            return false;
        }

        public bool MutateFormationDefFCLineMax(float formationDefFCLineMax)
        {
            return false;
        }

        public bool MutateFormationDefYFactor(float formationDefYFactor)
        {
            return false;
        }

        public bool MutateOppoManmarkingPlayerNum(int oppoManmarkingPlayerNum)
        {
            return false;
        }

        public bool MutateOppoHuntingPlayerNum(int oppoHuntingPlayerNum)
        {
            return false;
        }

        public bool MutateIdealShotDistance(float idealShotDistance)
        {
            return false;
        }

        public bool MutateAiAttackingRun(bool ai_attacking_run)
        {
            return false;
        }

        public bool MutateAiForwardSupport(bool ai_forward_support)
        {
            return false;
        }

        public bool MutateAiSupport(bool ai_support)
        {
            return false;
        }

        public bool MutateAiOffside(bool ai_offside)
        {
            return false;
        }

        public bool MutateAiOffsideTrap(bool ai_offside_trap)
        {
            return false;
        }

        public bool MutateAiInvalidatePassto(bool ai_invalidate_passto)
        {
            return false;
        }

        public bool MutateAiPasstoHero(bool ai_passto_hero)
        {
            return false;
        }

        public bool MutateAiDynamicFormation(bool ai_dynamic_formation)
        {
            return false;
        }

        public bool MutateAiNewMarkSupport(bool ai_new_mark_support)
        {
            return false;
        }

        public bool MutateAiPassMinimum(float ai_pass_minimum)
        {
            return false;
        }

        public bool MutateAiPassWeight(float ai_pass_weight)
        {
            return false;
        }

        public bool MutateAiAllowedToChaseBall(int ai_allowed_to_chase_ball)
        {
            return false;
        }

        public bool MutateMaxDefendDistance(float max_defend_distance)
        {
            return false;
        }

        public bool MutateMinDefendDistance(float min_defend_distance)
        {
            return false;
        }

        public bool MutateAiVersion(int ai_version)
        {
            return false;
        }

        public global::SLLevel.LevelPlayerData? Team1Players(int j)
        {
            return null;
        }

        public global::SLLevel.LevelPlayerData? Team2Players(int j)
        {
            return null;
        }

        public bool MutateHeroId(int HeroId)
        {
            return false;
        }

        public bool MutateStar0Type(int Star0Type)
        {
            return false;
        }

        public bool MutateStar0Id(int Star0Id)
        {
            return false;
        }

        public bool MutateStar1Type(int Star1Type)
        {
            return false;
        }

        public bool MutateStar1Player(int Star1Player)
        {
            return false;
        }

        public bool MutateShootCurve(float ShootCurve)
        {
            return false;
        }

        public bool MutateShootSnapRadius(float ShootSnapRadius)
        {
            return false;
        }

        public bool MutateSlMinShotMomentum(float sl_min_shot_momentum)
        {
            return false;
        }

        public bool MutateSlMaxShotMomentum(float sl_max_shot_momentum)
        {
            return false;
        }

        public bool MutateCineCameraFOV(float CineCameraFOV)
        {
            return false;
        }

        public global::SLLevel.TrainingTool? TrainingTools(int j)
        {
            return null;
        }

        public bool MutateOriScore(int OriScore)
        {
            return false;
        }

        public bool MutateTarScore(int TarScore)
        {
            return false;
        }

        public global::SLLevel.OperatorTool? OperatorTools(int j)
        {
            return null;
        }

        public global::SLLevel.BuffTool? BuffTools(int j)
        {
            return null;
        }

        public bool MutateAiGetToBallTimeLimit(int ai_get_to_ball_time_limit)
        {
            return false;
        }

        public bool MutateWoodwork(bool woodwork)
        {
            return false;
        }

        public bool MutateDeflectCheatoffsetScalar(float deflect_cheatoffset_scalar)
        {
            return false;
        }

        public bool MutateAiExtraReactionTimeMs(int ai_extra_reaction_time_ms)
        {
            return false;
        }

        public bool MutateShootAngleLimit(float shoot_angle_limit)
        {
            return false;
        }

        public bool MutateInputCountLimit(int input_count_limit)
        {
            return false;
        }

        public static void StartLevelData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddMatchState(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.MatchStateEnum MatchState)
        {
        }

        public static void AddMatchStartDelay(global::FlatBuffers.FlatBufferBuilder builder, int MatchStartDelay)
        {
        }

        public static void AddNovice(global::FlatBuffers.FlatBufferBuilder builder, bool Novice)
        {
        }

        public static void AddPitchHalfW(global::FlatBuffers.FlatBufferBuilder builder, float pitchHalfW)
        {
        }

        public static void AddPitchHalfH(global::FlatBuffers.FlatBufferBuilder builder, float pitchHalfH)
        {
        }

        public static void AddGoalBase(global::FlatBuffers.FlatBufferBuilder builder, float goalBase)
        {
        }

        public static void AddGoalDepth(global::FlatBuffers.FlatBufferBuilder builder, float goalDepth)
        {
        }

        public static void AddGoalHeight(global::FlatBuffers.FlatBufferBuilder builder, float goalHeight)
        {
        }

        public static void AddGoalHalfWidth(global::FlatBuffers.FlatBufferBuilder builder, float goalHalfWidth)
        {
        }

        public static void AddPenaltyAreaHalfW(global::FlatBuffers.FlatBufferBuilder builder, float penaltyAreaHalfW)
        {
        }

        public static void AddPenaltyAreaH(global::FlatBuffers.FlatBufferBuilder builder, float penaltyAreaH)
        {
        }

        public static void AddGravity(global::FlatBuffers.FlatBufferBuilder builder, float gravity)
        {
        }

        public static void AddBallRadius(global::FlatBuffers.FlatBufferBuilder builder, float ballRadius)
        {
        }

        public static void AddGroundFriction(global::FlatBuffers.FlatBufferBuilder builder, float groundFriction)
        {
        }

        public static void AddBallPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> BallPositionOffset)
        {
        }

        public static void AddBallMovYaw(global::FlatBuffers.FlatBufferBuilder builder, float BallMovYaw)
        {
        }

        public static void AddBallMovPitch(global::FlatBuffers.FlatBufferBuilder builder, float BallMovPitch)
        {
        }

        public static void AddBallMovSpeed(global::FlatBuffers.FlatBufferBuilder builder, float BallMovSpeed)
        {
        }

        public static void AddTeam1DatabaseId(global::FlatBuffers.FlatBufferBuilder builder, int Team1DatabaseId)
        {
        }

        public static void AddTeam2DatabaseId(global::FlatBuffers.FlatBufferBuilder builder, int Team2DatabaseId)
        {
        }

        public static void AddDifficulty(global::FlatBuffers.FlatBufferBuilder builder, float Difficulty)
        {
        }

        public static void AddCameraStartAngle(global::FlatBuffers.FlatBufferBuilder builder, float CameraStartAngle)
        {
        }

        public static void AddCameraStartHeight(global::FlatBuffers.FlatBufferBuilder builder, float CameraStartHeight)
        {
        }

        public static void AddCameraStartTan(global::FlatBuffers.FlatBufferBuilder builder, float CameraStartTan)
        {
        }

        public static void AddCameraFOV(global::FlatBuffers.FlatBufferBuilder builder, float CameraFOV)
        {
        }

        public static void AddCameraTan(global::FlatBuffers.FlatBufferBuilder builder, float CameraTan)
        {
        }

        public static void AddCameraY(global::FlatBuffers.FlatBufferBuilder builder, float CameraY)
        {
        }

        public static void AddCameraConstant(global::FlatBuffers.FlatBufferBuilder builder, bool CameraConstant)
        {
        }

        public static void AddFormationOffMinX(global::FlatBuffers.FlatBufferBuilder builder, float formationOffMinX)
        {
        }

        public static void AddFormationOffMinY(global::FlatBuffers.FlatBufferBuilder builder, float formationOffMinY)
        {
        }

        public static void AddFormationOffMaxX(global::FlatBuffers.FlatBufferBuilder builder, float formationOffMaxX)
        {
        }

        public static void AddFormationOffMaxY(global::FlatBuffers.FlatBufferBuilder builder, float formationOffMaxY)
        {
        }

        public static void AddFormationDefMinX(global::FlatBuffers.FlatBufferBuilder builder, float formationDefMinX)
        {
        }

        public static void AddFormationDefMinY(global::FlatBuffers.FlatBufferBuilder builder, float formationDefMinY)
        {
        }

        public static void AddFormationDefMaxX(global::FlatBuffers.FlatBufferBuilder builder, float formationDefMaxX)
        {
        }

        public static void AddFormationDefMaxY(global::FlatBuffers.FlatBufferBuilder builder, float formationDefMaxY)
        {
        }

        public static void AddFormationOffXLength(global::FlatBuffers.FlatBufferBuilder builder, float formationOffXLength)
        {
        }

        public static void AddFormationOffYLength(global::FlatBuffers.FlatBufferBuilder builder, float formationOffYLength)
        {
        }

        public static void AddFormationOffDCToBall(global::FlatBuffers.FlatBufferBuilder builder, float formationOffDCToBall)
        {
        }

        public static void AddFormationOffDCLineMin(global::FlatBuffers.FlatBufferBuilder builder, float formationOffDCLineMin)
        {
        }

        public static void AddFormationOffDCLineMax(global::FlatBuffers.FlatBufferBuilder builder, float formationOffDCLineMax)
        {
        }

        public static void AddFormationOffFCLineMin(global::FlatBuffers.FlatBufferBuilder builder, float formationOffFCLineMin)
        {
        }

        public static void AddFormationOffFCLineMax(global::FlatBuffers.FlatBufferBuilder builder, float formationOffFCLineMax)
        {
        }

        public static void AddFormationOffYFactor(global::FlatBuffers.FlatBufferBuilder builder, float formationOffYFactor)
        {
        }

        public static void AddFormationDefXLength(global::FlatBuffers.FlatBufferBuilder builder, float formationDefXLength)
        {
        }

        public static void AddFormationDefYLength(global::FlatBuffers.FlatBufferBuilder builder, float formationDefYLength)
        {
        }

        public static void AddFormationDefYLengthMin(global::FlatBuffers.FlatBufferBuilder builder, float formationDefYLengthMin)
        {
        }

        public static void AddFormationDefDCToBall(global::FlatBuffers.FlatBufferBuilder builder, float formationDefDCToBall)
        {
        }

        public static void AddFormationDefDCLineMin(global::FlatBuffers.FlatBufferBuilder builder, float formationDefDCLineMin)
        {
        }

        public static void AddFormationDefDCLineMax(global::FlatBuffers.FlatBufferBuilder builder, float formationDefDCLineMax)
        {
        }

        public static void AddFormationDefFCLineMin(global::FlatBuffers.FlatBufferBuilder builder, float formationDefFCLineMin)
        {
        }

        public static void AddFormationDefFCLineMax(global::FlatBuffers.FlatBufferBuilder builder, float formationDefFCLineMax)
        {
        }

        public static void AddFormationDefYFactor(global::FlatBuffers.FlatBufferBuilder builder, float formationDefYFactor)
        {
        }

        public static void AddOppoManmarkingPlayerNum(global::FlatBuffers.FlatBufferBuilder builder, int oppoManmarkingPlayerNum)
        {
        }

        public static void AddOppoHuntingPlayerNum(global::FlatBuffers.FlatBufferBuilder builder, int oppoHuntingPlayerNum)
        {
        }

        public static void AddIdealShotDistance(global::FlatBuffers.FlatBufferBuilder builder, float idealShotDistance)
        {
        }

        public static void AddAiAttackingRun(global::FlatBuffers.FlatBufferBuilder builder, bool aiAttackingRun)
        {
        }

        public static void AddAiForwardSupport(global::FlatBuffers.FlatBufferBuilder builder, bool aiForwardSupport)
        {
        }

        public static void AddAiSupport(global::FlatBuffers.FlatBufferBuilder builder, bool aiSupport)
        {
        }

        public static void AddAiOffside(global::FlatBuffers.FlatBufferBuilder builder, bool aiOffside)
        {
        }

        public static void AddAiOffsideTrap(global::FlatBuffers.FlatBufferBuilder builder, bool aiOffsideTrap)
        {
        }

        public static void AddAiInvalidatePassto(global::FlatBuffers.FlatBufferBuilder builder, bool aiInvalidatePassto)
        {
        }

        public static void AddAiPasstoHero(global::FlatBuffers.FlatBufferBuilder builder, bool aiPasstoHero)
        {
        }

        public static void AddAiDynamicFormation(global::FlatBuffers.FlatBufferBuilder builder, bool aiDynamicFormation)
        {
        }

        public static void AddAiNewMarkSupport(global::FlatBuffers.FlatBufferBuilder builder, bool aiNewMarkSupport)
        {
        }

        public static void AddAiPassMinimum(global::FlatBuffers.FlatBufferBuilder builder, float aiPassMinimum)
        {
        }

        public static void AddAiPassWeight(global::FlatBuffers.FlatBufferBuilder builder, float aiPassWeight)
        {
        }

        public static void AddAiAllowedToChaseBall(global::FlatBuffers.FlatBufferBuilder builder, int aiAllowedToChaseBall)
        {
        }

        public static void AddMaxDefendDistance(global::FlatBuffers.FlatBufferBuilder builder, float maxDefendDistance)
        {
        }

        public static void AddMinDefendDistance(global::FlatBuffers.FlatBufferBuilder builder, float minDefendDistance)
        {
        }

        public static void AddAiVersion(global::FlatBuffers.FlatBufferBuilder builder, int aiVersion)
        {
        }

        public static void AddTeam1Players(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset Team1PlayersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTeam1PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelPlayerData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTeam1PlayersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelPlayerData>[] data)
        {
            return default;
        }

        public static void StartTeam1PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddTeam2Players(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset Team2PlayersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTeam2PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelPlayerData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTeam2PlayersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelPlayerData>[] data)
        {
            return default;
        }

        public static void StartTeam2PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddHeroId(global::FlatBuffers.FlatBufferBuilder builder, int HeroId)
        {
        }

        public static void AddStar0Type(global::FlatBuffers.FlatBufferBuilder builder, int Star0Type)
        {
        }

        public static void AddStar0Id(global::FlatBuffers.FlatBufferBuilder builder, int Star0Id)
        {
        }

        public static void AddStar0Position(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> Star0PositionOffset)
        {
        }

        public static void AddStar1Type(global::FlatBuffers.FlatBufferBuilder builder, int Star1Type)
        {
        }

        public static void AddStar1Player(global::FlatBuffers.FlatBufferBuilder builder, int Star1Player)
        {
        }

        public static void AddStar1Position(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> Star1PositionOffset)
        {
        }

        public static void AddShootPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector2> ShootPosOffset)
        {
        }

        public static void AddShootCurve(global::FlatBuffers.FlatBufferBuilder builder, float ShootCurve)
        {
        }

        public static void AddShootSnapRadius(global::FlatBuffers.FlatBufferBuilder builder, float ShootSnapRadius)
        {
        }

        public static void AddSlMinShotMomentum(global::FlatBuffers.FlatBufferBuilder builder, float slMinShotMomentum)
        {
        }

        public static void AddSlMaxShotMomentum(global::FlatBuffers.FlatBufferBuilder builder, float slMaxShotMomentum)
        {
        }

        public static void AddCineCameraPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> CineCameraPosOffset)
        {
        }

        public static void AddCineCameraFOV(global::FlatBuffers.FlatBufferBuilder builder, float CineCameraFOV)
        {
        }

        public static void AddTrainingTools(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset TrainingToolsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTrainingToolsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.TrainingTool>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTrainingToolsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.TrainingTool>[] data)
        {
            return default;
        }

        public static void StartTrainingToolsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOriScore(global::FlatBuffers.FlatBufferBuilder builder, int OriScore)
        {
        }

        public static void AddTarScore(global::FlatBuffers.FlatBufferBuilder builder, int TarScore)
        {
        }

        public static void AddOperatorTools(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset OperatorToolsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOperatorToolsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.OperatorTool>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOperatorToolsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.OperatorTool>[] data)
        {
            return default;
        }

        public static void StartOperatorToolsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddBuffTools(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset BuffToolsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateBuffToolsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.BuffTool>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateBuffToolsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.BuffTool>[] data)
        {
            return default;
        }

        public static void StartBuffToolsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddBallService(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.BallService> BallServiceOffset)
        {
        }

        public static void AddAiGetToBallTimeLimit(global::FlatBuffers.FlatBufferBuilder builder, int aiGetToBallTimeLimit)
        {
        }

        public static void AddWoodwork(global::FlatBuffers.FlatBufferBuilder builder, bool woodwork)
        {
        }

        public static void AddDeflectCheatoffsetScalar(global::FlatBuffers.FlatBufferBuilder builder, float deflectCheatoffsetScalar)
        {
        }

        public static void AddAiExtraReactionTimeMs(global::FlatBuffers.FlatBufferBuilder builder, int aiExtraReactionTimeMs)
        {
        }

        public static void AddShootAngleLimit(global::FlatBuffers.FlatBufferBuilder builder, float shootAngleLimit)
        {
        }

        public static void AddGolfTarget(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.GolfTarget> GolfTargetOffset)
        {
        }

        public static void AddInputCountLimit(global::FlatBuffers.FlatBufferBuilder builder, int inputCountLimit)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.LevelData> EndLevelData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }

        public static void FinishLevelDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelData> offset)
        {
        }

        public static void FinishSizePrefixedLevelDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.LevelData> offset)
        {
        }
    }
}