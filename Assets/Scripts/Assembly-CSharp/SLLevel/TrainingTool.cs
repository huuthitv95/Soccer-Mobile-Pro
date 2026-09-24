namespace SLLevel
{
    public struct TrainingTool : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Type => 0;
        public global::SLLevel.CollisionShapeType ShapeType => global::SLLevel.CollisionShapeType.Box;
        public int ShapeParametersLength => 0;
        public int ShapesLength => 0;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.Vector3? Rotation => null;
        public global::SLLevel.Vector3? Scale => null;
        public float Mass => 0f;
        public float Friction => 0f;
        public float Restitution => 0f;
        public bool Touchable => false;
        public bool Goalable => false;
        public bool Brokenable => false;
        public bool Collision => false;
        public int MarkLength => 0;
        public int MovementLength => 0;
        public int RotationsLength => 0;
        public int SwingsLength => 0;
        public global::SLLevel.GoalType GoalType => global::SLLevel.GoalType.GoalNormal;
        public global::SLLevel.ToolType ToolType => global::SLLevel.ToolType.ToolNormal;

        public static global::SLLevel.TrainingTool GetRootAsTrainingTool(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.TrainingTool GetRootAsTrainingTool(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.TrainingTool obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.TrainingTool __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateType(int type)
        {
            return false;
        }

        public bool MutateShapeType(global::SLLevel.CollisionShapeType shapeType)
        {
            return false;
        }

        public float ShapeParameters(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetShapeParametersBytes()
        {
            return null;
        }

        public float[] GetShapeParametersArray()
        {
            return null;
        }

        public bool MutateShapeParameters(int j, float shapeParameters)
        {
            return false;
        }

        public global::SLLevel.CollisoinShape? Shapes(int j)
        {
            return null;
        }

        public bool MutateMass(float mass)
        {
            return false;
        }

        public bool MutateFriction(float friction)
        {
            return false;
        }

        public bool MutateRestitution(float restitution)
        {
            return false;
        }

        public bool MutateTouchable(bool touchable)
        {
            return false;
        }

        public bool MutateGoalable(bool goalable)
        {
            return false;
        }

        public bool MutateBrokenable(bool brokenable)
        {
            return false;
        }

        public bool MutateCollision(bool collision)
        {
            return false;
        }

        public float Mark(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetMarkBytes()
        {
            return null;
        }

        public float[] GetMarkArray()
        {
            return null;
        }

        public bool MutateMark(int j, float mark)
        {
            return false;
        }

        public float Movement(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetMovementBytes()
        {
            return null;
        }

        public float[] GetMovementArray()
        {
            return null;
        }

        public bool MutateMovement(int j, float movement)
        {
            return false;
        }

        public float Rotations(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetRotationsBytes()
        {
            return null;
        }

        public float[] GetRotationsArray()
        {
            return null;
        }

        public bool MutateRotations(int j, float rotations)
        {
            return false;
        }

        public float Swings(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetSwingsBytes()
        {
            return null;
        }

        public float[] GetSwingsArray()
        {
            return null;
        }

        public bool MutateSwings(int j, float swings)
        {
            return false;
        }

        public bool MutateGoalType(global::SLLevel.GoalType goalType)
        {
            return false;
        }

        public bool MutateToolType(global::SLLevel.ToolType toolType)
        {
            return false;
        }

        public static void StartTrainingTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddType(global::FlatBuffers.FlatBufferBuilder builder, int type)
        {
        }

        public static void AddShapeType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.CollisionShapeType shapeType)
        {
        }

        public static void AddShapeParameters(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset shapeParametersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateShapeParametersVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateShapeParametersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartShapeParametersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddShapes(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset shapesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateShapesVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CollisoinShape>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateShapesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CollisoinShape>[] data)
        {
            return default;
        }

        public static void StartShapesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> positionOffset)
        {
        }

        public static void AddRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> rotationOffset)
        {
        }

        public static void AddScale(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> scaleOffset)
        {
        }

        public static void AddMass(global::FlatBuffers.FlatBufferBuilder builder, float mass)
        {
        }

        public static void AddFriction(global::FlatBuffers.FlatBufferBuilder builder, float friction)
        {
        }

        public static void AddRestitution(global::FlatBuffers.FlatBufferBuilder builder, float restitution)
        {
        }

        public static void AddTouchable(global::FlatBuffers.FlatBufferBuilder builder, bool touchable)
        {
        }

        public static void AddGoalable(global::FlatBuffers.FlatBufferBuilder builder, bool goalable)
        {
        }

        public static void AddBrokenable(global::FlatBuffers.FlatBufferBuilder builder, bool brokenable)
        {
        }

        public static void AddCollision(global::FlatBuffers.FlatBufferBuilder builder, bool collision)
        {
        }

        public static void AddMark(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset markOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateMarkVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateMarkVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartMarkVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddMovement(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset movementOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateMovementVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateMovementVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartMovementVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddRotations(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset rotationsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateRotationsVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateRotationsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartRotationsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddSwings(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset swingsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSwingsVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSwingsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartSwingsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddGoalType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.GoalType goalType)
        {
        }

        public static void AddToolType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.ToolType toolType)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.TrainingTool> EndTrainingTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}