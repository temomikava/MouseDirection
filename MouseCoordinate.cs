class MouseCoordinate
{
    public int Horizontal { get; set; }
    public MouseCoordinateStatus Status { get; set; }
    public MouseCoordinate(int horizontal, MouseCoordinateStatus status)
    {
        Horizontal = horizontal;
        Status = status;
    }
}
