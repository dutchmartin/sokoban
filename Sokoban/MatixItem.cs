public class MatrixItem
{
    public MatrixItem North { get; set; }
    public MatrixItem East { get; set; }
    public MatrixItem South { get; set; }
    public MatrixItem West { get; set; }

    public bool isDestination { get; set; }
}