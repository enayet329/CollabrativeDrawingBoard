public class Drawing
{
    public Guid Id { get; set; }
    public Guid BoardId { get; set; }
    public Guid UserId { get; set; }
    public string? Type { get; set; } // "line", "rectangle", "circle", "text", "triangle", etc.
    public string? Color { get; set; } // Hex color code

    // Properties for drawing details
    public int StartPointX { get; set; }
    public int StartPointY { get; set; }
    public int EndPointX { get; set; }
    public int EndPointY { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? Text { get; set; }

    // Properties for triangle vertices
    public int Vertex1X { get; set; }
    public int Vertex1Y { get; set; }
    public int Vertex2X { get; set; }
    public int Vertex2Y { get; set; }
    public int Vertex3X { get; set; }
    public int Vertex3Y { get; set; }

    public DateTime CreatedAt { get; set; }
}