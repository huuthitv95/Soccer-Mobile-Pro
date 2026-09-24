public class GUITourEventMapLayout : global::UnityEngine.MonoBehaviour
{
    private class LayoutNode
    {
        public int Id;
        public int Column;
        public int Row;
        public float PreferredRow;
        public global::UnityEngine.Vector2 Position;
        public global::UnityEngine.Vector2 Size;
        public LayoutNode(int id, int column)
        {
        }
    }

    private struct LayoutEdge
    {
        public int FromId;
        public int ToId;
        public LayoutEdge(int fromId, int toId)
        {
            FromId = 0;
            ToId = 0;
        }
    }

    private struct PlannedSegment
    {
        public int FromId;
        public int ToId;
        public global::UnityEngine.Vector2 Start;
        public global::UnityEngine.Vector2 End;
        public bool ExtendStart;
        public bool ExtendEnd;
        public PlannedSegment(int fromId, int toId, global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end, bool extendStart, bool extendEnd)
        {
            FromId = 0;
            ToId = 0;
            Start = default;
            End = default;
            ExtendStart = false;
            ExtendEnd = false;
        }
    }

    private class MapLinePlan
    {
        public int FromId;
        public int ToId;
        public global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> Segments;
        public MapLinePlan(int fromId, int toId, global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> segments)
        {
        }
    }

    private const string NodeNamePrefix = "tourMapNode_";
    private const string LineNamePrefix = "tourMapLine_";
    private const float PositionEpsilon = 0.5f;
    private const int CrossingScoreWeight = 1000;
    private const int NodeHitScoreWeight = 100;
    private const int LayerSortIterations = 8;
    public const int MapEdgeNodeId = 0;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform mapBounds;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform mapNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform mapLine;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform nodeRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform lineRoot;
    [global::UnityEngine.SerializeField]
    private float horizontalPadding;
    [global::UnityEngine.SerializeField]
    private float verticalPadding;
    [global::UnityEngine.SerializeField]
    private float lineThickness;
    [global::UnityEngine.SerializeField]
    private float lineNodeOverlap;
    [global::UnityEngine.SerializeField]
    private int maxRouteCount;
    [global::UnityEngine.SerializeField]
    private bool hideTemplates;
    [global::UnityEngine.SerializeField]
    private bool warnWhenLinesCross;
    private readonly global::System.Collections.Generic.Dictionary<int, global::UnityEngine.RectTransform> generatedNodes;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.RectTransform> generatedLines;
    private readonly global::System.Collections.Generic.Dictionary<string, GUITourEventMapLine> generatedLineMap;
    private readonly global::System.Collections.Generic.List<GUITourEventMapLine> generatedLineViews;
    public global::System.Collections.Generic.Dictionary<int, global::UnityEngine.RectTransform> GeneratedNodes => null;
    public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> GeneratedLines => null;
    public global::System.Collections.Generic.List<GUITourEventMapLine> GeneratedLineViews => null;

    public global::UnityEngine.RectTransform GetNode(int nodeId)
    {
        return null;
    }

    public bool TryGetNode(int nodeId, out global::UnityEngine.RectTransform node)
    {
        node = null;
        return false;
    }

    public GUITourEventMapLine GetLine(int fromId, int toId)
    {
        return null;
    }

    public bool TryGetLine(int fromId, int toId, out GUITourEventMapLine line)
    {
        line = null;
        return false;
    }

    public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> GetLineImages(int fromId, int toId)
    {
        return null;
    }

    public void GetLineImages(int fromId, int toId, global::System.Collections.Generic.List<global::UnityEngine.UI.Image> images)
    {
    }

    public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> GetAllLineImages()
    {
        return null;
    }

    public void GetAllLineImages(global::System.Collections.Generic.List<global::UnityEngine.UI.Image> images)
    {
    }

    public void Build(global::FL.TourEvent.TourEventMapConfig mapConfig)
    {
    }

    public void Build(global::System.Collections.Generic.IList<int> nodeIds, global::System.Collections.Generic.IDictionary<int, int[]> adjacencyList, global::System.Collections.Generic.IList<int> entryNodeIds, int finalNodeId)
    {
    }

    public void ClearLayout()
    {
    }

    private global::System.Collections.Generic.List<int> BuildOrderedNodeIds(global::System.Collections.Generic.IList<int> nodeIds, global::System.Collections.Generic.IDictionary<int, int[]> adjacencyList, global::System.Collections.Generic.IList<int> entryNodeIds, int finalNodeId)
    {
        return null;
    }

    private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> BuildAdjacency(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.IDictionary<int, int[]> adjacencyList)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> BuildEntryNodeIds(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> adjacency, global::System.Collections.Generic.IList<int> entryNodeIds)
    {
        return null;
    }

    private global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> BuildEdges(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> adjacency)
    {
        return null;
    }

    private global::System.Collections.Generic.Dictionary<int, int> BuildColumns(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> adjacency, global::System.Collections.Generic.List<int> entries)
    {
        return null;
    }

    private void ForceFinalColumn(global::System.Collections.Generic.Dictionary<int, int> columns, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, int finalNodeId)
    {
    }

    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> BuildRoutes(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> adjacency, global::System.Collections.Generic.List<int> entries, int finalNodeId)
    {
        return null;
    }

    private void CollectRoutes(int nodeId, int finalNodeId, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> adjacency, global::System.Collections.Generic.HashSet<int> nodeIdSet, global::System.Collections.Generic.List<int> path, global::System.Collections.Generic.HashSet<int> visiting, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> routes, int routeLimit)
    {
    }

    private global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> BuildLayoutNodes(global::System.Collections.Generic.List<int> nodeIds, global::System.Collections.Generic.Dictionary<int, int> columns, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> routes, global::UnityEngine.RectTransform bounds, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges)
    {
        return null;
    }

    private int GetLayoutRowCount(int minimumRowCount, int routeCount, global::UnityEngine.RectTransform bounds)
    {
        return 0;
    }

    private int GetMaxLayoutRowCount(global::UnityEngine.RectTransform bounds)
    {
        return 0;
    }

    private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> BuildRouteIndexesByNode(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> routes)
    {
        return null;
    }

    private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutNode>> BuildLayers(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return null;
    }

    private void AssignInitialRows(global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutNode>> layers, int rowCount)
    {
    }

    private void MinimizeLayerCrossings(global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutNode>> layers, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, int rowCount)
    {
    }

    private void SortLayerByNeighbors(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutNode> layer, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, int rowCount, bool useIncoming)
    {
    }

    private int CompareNodeByNeighborMedian(GUITourEventMapLayout.LayoutNode left, GUITourEventMapLayout.LayoutNode right, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, int> originalOrder, bool useIncoming)
    {
        return 0;
    }

    private float GetNeighborMedianRow(GUITourEventMapLayout.LayoutNode node, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, bool useIncoming)
    {
        return 0f;
    }

    private void AssignSpreadRows(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutNode> layer, int rowCount)
    {
    }

    private global::System.Collections.Generic.Dictionary<int, int> CaptureRows(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return null;
    }

    private void RestoreRows(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.Dictionary<int, int> rows)
    {
    }

    private void SaveBestRowsIfNeeded(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, ref int bestScore, global::System.Collections.Generic.Dictionary<int, int> bestRows)
    {
    }

    private int ScoreLayeredLayout(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return 0;
    }

    private int CountLayoutCrossings(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return 0;
    }

    private bool DoLayoutEdgesCross(GUITourEventMapLayout.LayoutEdge left, GUITourEventMapLayout.LayoutEdge right, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return false;
    }

    private int CountLineNodeHits(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return 0;
    }

    private void ResolveStraightLineNodeConflicts(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, int rowCount)
    {
    }

    private bool TryFindLineNodeBlocker(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, GUITourEventMapLayout.LayoutNode fromNode, GUITourEventMapLayout.LayoutNode toNode, out GUITourEventMapLayout.LayoutNode blocker, out int blockedRow)
    {
        blocker = null;
        blockedRow = default;
        return false;
    }

    private bool DoesLayoutEdgeHitNode(GUITourEventMapLayout.LayoutNode fromNode, GUITourEventMapLayout.LayoutNode toNode, GUITourEventMapLayout.LayoutNode layoutNode)
    {
        return false;
    }

    private int GetLayoutEdgeRowAtColumn(GUITourEventMapLayout.LayoutNode fromNode, GUITourEventMapLayout.LayoutNode toNode, int column)
    {
        return 0;
    }

    private bool TryMoveNodeToFreeRow(GUITourEventMapLayout.LayoutNode layoutNode, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, int rowCount, int blockedRow)
    {
        return false;
    }

    private bool TryUseRow(GUITourEventMapLayout.LayoutNode layoutNode, bool[] usedRows, int row, int rowCount, int blockedRow)
    {
        return false;
    }

    private void ApplyNodePositions(global::UnityEngine.RectTransform bounds, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
    }

    private void CreateNodeViews(global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
    }

    private void CreateLineViews(global::System.Collections.Generic.List<GUITourEventMapLayout.LayoutEdge> edges, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, global::UnityEngine.RectTransform bounds, int finalNodeId)
    {
    }

    private void AddLinePlan(global::System.Collections.Generic.List<GUITourEventMapLayout.MapLinePlan> linePlans, global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> plannedSegments, int fromId, int toId, global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> segments)
    {
    }

    private void AddFinalEdgeLine(global::System.Collections.Generic.List<GUITourEventMapLayout.MapLinePlan> linePlans, global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> plannedSegments, global::UnityEngine.RectTransform bounds, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes, int finalNodeId)
    {
    }

    private global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> BuildEdgeSegments(GUITourEventMapLayout.LayoutEdge edge, GUITourEventMapLayout.LayoutNode fromNode, GUITourEventMapLayout.LayoutNode toNode)
    {
        return null;
    }

    private void CreateLineView(global::UnityEngine.RectTransform parent, GUITourEventMapLayout.MapLinePlan linePlan, global::System.Collections.Generic.Dictionary<string, global::UnityEngine.RectTransform> sharedSegments, ref int segmentIndex)
    {
    }

    private global::UnityEngine.RectTransform CreateLineSegmentView(global::UnityEngine.RectTransform parent, GUITourEventMapLayout.PlannedSegment segment, int segmentIndex)
    {
        return null;
    }

    private global::UnityEngine.RectTransform CreateLineContainer(global::UnityEngine.RectTransform parent, string itemName)
    {
        return null;
    }

    private global::UnityEngine.RectTransform CreateItem(global::UnityEngine.RectTransform template, global::UnityEngine.Transform parent, string itemName)
    {
        return null;
    }

    private void SetAnchoredPosition(global::UnityEngine.RectTransform item, global::UnityEngine.RectTransform parent, global::UnityEngine.Vector2 position)
    {
    }

    private void SetAnchoredPosition(global::UnityEngine.RectTransform item, global::UnityEngine.RectTransform parent, global::UnityEngine.Vector2 position, bool convertFromBounds)
    {
    }

    private global::UnityEngine.Vector2 ConvertBoundsPositionToLocal(global::UnityEngine.RectTransform targetRoot, global::UnityEngine.Vector2 boundsPosition)
    {
        return default;
    }

    private void ExtendLineSegment(GUITourEventMapLayout.PlannedSegment segment, ref global::UnityEngine.Vector2 start, ref global::UnityEngine.Vector2 end)
    {
    }

    private void ClearGeneratedChildren(global::UnityEngine.Transform root, string namePrefix)
    {
    }

    private void ApplyTemplateVisibility()
    {
    }

    private global::UnityEngine.RectTransform ResolveBounds()
    {
        return null;
    }

    private global::UnityEngine.RectTransform ResolveNodeRoot()
    {
        return null;
    }

    private global::UnityEngine.RectTransform ResolveLineRoot()
    {
        return null;
    }

    private global::UnityEngine.Vector2 GetEdgePoint(GUITourEventMapLayout.LayoutNode fromNode, global::UnityEngine.Vector2 targetPosition)
    {
        return default;
    }

    private float GetLineThickness()
    {
        return 0f;
    }

    private int CompareLayoutNodeByPreferredRow(GUITourEventMapLayout.LayoutNode left, GUITourEventMapLayout.LayoutNode right)
    {
        return 0;
    }

    private int CompareLayoutNodeByColumn(GUITourEventMapLayout.LayoutNode left, GUITourEventMapLayout.LayoutNode right)
    {
        return 0;
    }

    private int CompareLayoutEdge(GUITourEventMapLayout.LayoutEdge left, GUITourEventMapLayout.LayoutEdge right, global::System.Collections.Generic.Dictionary<int, GUITourEventMapLayout.LayoutNode> layoutNodes)
    {
        return 0;
    }

    private int CountCrossings(global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> candidateSegments, global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> plannedSegments)
    {
        return 0;
    }

    private int CountCrossings(global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> segments, int startIndex, int endIndex)
    {
        return 0;
    }

    private bool IsCrossing(GUITourEventMapLayout.PlannedSegment left, GUITourEventMapLayout.PlannedSegment right)
    {
        return false;
    }

    private bool SegmentsCrossStrict(global::UnityEngine.Vector2 firstStart, global::UnityEngine.Vector2 firstEnd, global::UnityEngine.Vector2 secondStart, global::UnityEngine.Vector2 secondEnd)
    {
        return false;
    }

    private float Cross(global::UnityEngine.Vector2 origin, global::UnityEngine.Vector2 axisPoint, global::UnityEngine.Vector2 point)
    {
        return 0f;
    }

    private void AddSegment(global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> segments, GUITourEventMapLayout.LayoutEdge edge, global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end)
    {
    }

    private void AddSegment(global::System.Collections.Generic.List<GUITourEventMapLayout.PlannedSegment> segments, GUITourEventMapLayout.LayoutEdge edge, global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end, bool extendStart, bool extendEnd)
    {
    }

    private string BuildSegmentKey(GUITourEventMapLayout.PlannedSegment segment)
    {
        return null;
    }

    private bool IsPointAfter(global::UnityEngine.Vector2 left, global::UnityEngine.Vector2 right)
    {
        return false;
    }

    private string BuildPointKey(global::UnityEngine.Vector2 point)
    {
        return null;
    }

    private string BuildLineKey(int fromId, int toId)
    {
        return null;
    }

    private void AddUnique(global::System.Collections.Generic.List<int> list, int value)
    {
    }

    private void DestroyGenerated(global::UnityEngine.GameObject target)
    {
    }
}