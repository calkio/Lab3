using Lab3;

internal class Program
{
    #region PATH_MATRIX
    static private string _pathFileMatrixX = @"D:\Dev\Calibrovka\Matrix\0\X.json";
    static private string _pathFileMatrixY = @"D:\Dev\Calibrovka\Matrix\0\Y.json";
           
    static private string _pathFileMatrixX60 = @"D:\Dev\Calibrovka\Matrix\60\X.json";
    static private string _pathFileMatrixY60 = @"D:\Dev\Calibrovka\Matrix\60\Y.json";
           
    static private string _pathFileMatrixX70 = @"D:\Dev\Calibrovka\Matrix\70\X.json";
    static private string _pathFileMatrixY70 = @"D:\Dev\Calibrovka\Matrix\70\Y.json";
           
    static private string _pathFileMatrixX100 = @"D:\Dev\Calibrovka\Matrix\100\X.json";
    static private string _pathFileMatrixY100 = @"D:\Dev\Calibrovka\Matrix\100\Y.json";
           
    static private string _pathFileMatrixXTop246 = @"D:\Dev\Calibrovka\Matrix\Top246\X.json";
    static private string _pathFileMatrixYTop246 = @"D:\Dev\Calibrovka\Matrix\Top246\Y.json";
           
    static private string _pathFileMatrixXTop264 = @"D:\Dev\Calibrovka\Matrix\Top264\X.json";
    static private string _pathFileMatrixYTop264 = @"D:\Dev\Calibrovka\Matrix\Top264\Y.json";
           
    static private string _pathFileMatrixXTop272 = @"D:\Dev\Calibrovka\Matrix\Top272\X.json";
    static private string _pathFileMatrixYTop272 = @"D:\Dev\Calibrovka\Matrix\Top272\Y.json";
    #endregion

    #region MATRIX
    static private double[,] _matrixX0;
    static private double[,] _matrixY0;
    
    static private double[,] _matrixX60;
    static private double[,] _matrixY60;
    
    static private double[,] _matrixX70;
    static private double[,] _matrixY70;
    
    static private double[,] _matrixX100;
    static private double[,] _matrixY100;
    
    static private double[,] _matrixXTop246;
    static private double[,] _matrixYTop246;
    
    static private double[,] _matrixXTop264;
    static private double[,] _matrixYTop264;
    
    static private double[,] _matrixXTop272;
    static private double[,] _matrixYTop272;
    #endregion

    private static void Main(string[] args)
    {
        Start().Wait(); // Дождаться завершения выполнения Start()
        Console.WriteLine("End!");
        Console.ReadLine();
    }

    private static async Task Start() 
    { 
        await LoadMatricesAsync();
    }

    private static async Task LoadMatricesAsync()
    {
        var tasks = new List<Task<double[,]>>()
        {
            GetMatrixAsync(_pathFileMatrixX),
            GetMatrixAsync(_pathFileMatrixY),

            GetMatrixAsync(_pathFileMatrixX60),
            GetMatrixAsync(_pathFileMatrixY60),

            GetMatrixAsync(_pathFileMatrixX70),
            GetMatrixAsync(_pathFileMatrixY70),

            GetMatrixAsync(_pathFileMatrixX100),
            GetMatrixAsync(_pathFileMatrixY100),

            GetMatrixAsync(_pathFileMatrixXTop246),
            GetMatrixAsync(_pathFileMatrixYTop246),

            GetMatrixAsync(_pathFileMatrixXTop264),
            GetMatrixAsync(_pathFileMatrixYTop264),

            GetMatrixAsync(_pathFileMatrixXTop272),
            GetMatrixAsync(_pathFileMatrixYTop272)
        };

        await Task.WhenAll(tasks);

        _matrixX0 = tasks[0].Result;
        _matrixY0 = tasks[1].Result;
        await Console.Out.WriteLineAsync($"{tasks[0].Result}, {tasks[1].Result}");

        _matrixX60 = tasks[2].Result;
        _matrixY60 = tasks[3].Result;
        await Console.Out.WriteLineAsync($"{tasks[2].Result}, {tasks[3].Result}");

        _matrixX70 = tasks[4].Result;
        _matrixY70 = tasks[5].Result;
        await Console.Out.WriteLineAsync($"{tasks[4].Result}, {tasks[5].Result}");

        _matrixX100 = tasks[6].Result;
        _matrixY100 = tasks[7].Result;
        await Console.Out.WriteLineAsync($"{tasks[6].Result}, {tasks[7].Result}");

        _matrixXTop246 = tasks[8].Result;
        _matrixYTop246 = tasks[9].Result;
        await Console.Out.WriteLineAsync($"{tasks[8].Result}, {tasks[9].Result}");

        _matrixXTop264 = tasks[10].Result;
        _matrixYTop264 = tasks[11].Result;
        await Console.Out.WriteLineAsync($"{tasks[10].Result}, {tasks[11].Result}");

        _matrixXTop272 = tasks[12].Result;
        _matrixYTop272 = tasks[13].Result;
        await Console.Out.WriteLineAsync($"{tasks[12].Result}, {tasks[13].Result}");
    }

    private static Task<double[,]> GetMatrixAsync(string pathFile)
    {
        return Task.Run(() =>
        {
            Matrix getMatrix = new Matrix();
            return getMatrix.GetMatrix(pathFile);
        });
    }


}