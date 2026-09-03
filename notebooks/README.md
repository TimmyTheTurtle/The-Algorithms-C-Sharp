# Interactive Algorithm Learning with LINQPad

These `.linq` query files provide an interactive way to explore algorithms using **LINQPad**, the premier C# interactive environment.

## 📝 What is LINQPad?

**LINQPad** is the gold standard for interactive C# development:
- Write and execute C# code instantly
- See results immediately
- Modify code and re-run without recompiling
- Works perfectly with local files and classes
- Free version available (very capable)
- Still actively maintained and developed

## 🚀 Getting Started

1. **Download LINQPad**
   - Go to [www.linqpad.net](https://www.linqpad.net)
   - Download the free version (or Premium for additional features)
   - Install and launch

2. **Install VS Code Extension** (Optional)
   - Search for "linqpad" in VS Code Extensions
   - Install `sharwell.linqpad` by Sam Harwell
   - Allows previewing `.linq` files in VS Code

3. **Open a Query File**
   - In LINQPad: File → Open
   - Navigate to `notebooks/` folder
   - Open any `.linq` file
   - Click the "Run" button or press Ctrl+Shift+Enter

4. **Start Learning**
   - Read the markdown comments
   - Modify the code
   - Press Ctrl+Shift+Enter to re-run
   - See output in the "Results" pane

## 📂 Available Query Files

### 100-Level Fundamentals
- `100-level-numeric.linq` - Factorial, Fibonacci, GCD
- `100-level-strings.linq` - String operations, palindromes
- `100-level-sorting.linq` - Bubble sort, basic sorting

### 200-Level Intermediate
- `200-level-searching.linq` - Binary search, jump search, exponential search
- `200-level-sorting.linq` - Merge sort, Quick sort, efficient algorithms
- `200-level-graphs.linq` - BFS, DFS, graph traversal

### 300-Level Advanced
- `300-level-dp.linq` - Dynamic programming problems
- `300-level-graphs.linq` - Dijkstra, MST, advanced graph algorithms
- `300-level-math.linq` - Matrix operations, modular arithmetic

### 400-Level Senior
- `400-level-advanced.linq` - A* pathfinding, TimSort, production algorithms

### Specialized
- `specialized-crypto.linq` - Hash functions, padding schemes
- `specialized-ml.linq` - ML algorithms, regression
- `specialized-finance.linq` - Financial calculations

## 💡 LINQPad Tips & Tricks

### Basic Commands
```
Ctrl+Shift+Enter    Run the query
Ctrl+E              Execute
Ctrl+Alt+F5         Run as console application
.Clear()            Clear the output
.Dump()             Pretty-print objects to results
.Dump("Title")      Dump with a title
```

### Accessing Your Algorithms

You can reference your algorithm files directly:

```csharp
// Option 1: Load from file
#load @"..\Algorithms\100-level\Numeric\Factorial.cs"

// Then use it
var result = Factorial.Calculate(10);
result.Dump("10! = ");
```

### Output Formatting

```csharp
// Structured output
new { Number = 10, Factorial = 3628800 }.Dump();

// Formatted tables
var data = Enumerable.Range(1, 10)
    .Select(n => new { n, Factorial = CalculateFactorial(n) })
    .Dump("Factorial Table");

// Time measurements
using (new StopWatch("My Algorithm"))
{
    // Your algorithm here
}
```

### Common Patterns

```csharp
// Test multiple inputs
new[] { 5, 10, 20 }
    .Select(n => new { Input = n, Output = MyAlgorithm(n) })
    .Dump("Results");

// Compare two implementations
void ComparePerformance()
{
    var iterations = 1000000;
    
    var sw1 = Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++) Method1();
    sw1.Stop();
    
    var sw2 = Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++) Method2();
    sw2.Stop();
    
    new { Method1 = sw1.ElapsedMilliseconds, Method2 = sw2.ElapsedMilliseconds }
        .Dump("Performance Comparison");
}
```

## 📊 Learning Workflow

1. **Start with a level** - Open `100-level-numeric.linq`
2. **Read the comments** - Understand what each section does
3. **Run the code** - Press Ctrl+Shift+Enter
4. **Modify it** - Change parameters and re-run
5. **Explore** - Try edge cases, add more test data
6. **Challenge yourself** - Implement your own algorithm in a new cell

## 🎯 Benefits of LINQPad for Algorithm Learning

✅ **Instant feedback** - See results immediately  
✅ **No boilerplate** - Just write code, no Main() needed  
✅ **Interactive exploration** - Modify and re-run without recompiling  
✅ **Beautiful output** - Automatic formatting of objects and collections  
✅ **Performance testing** - Built-in stopwatch and timing  
✅ **Still maintained** - Active development and support  
✅ **Free version** - Full features in the free tier  

## 🔗 Resources

- **LINQPad Official**: https://www.linqpad.net
- **LINQPad Docs**: https://www.linqpad.net/syntax.html
- **LINQPad Tips**: https://www.linqpad.net/tips.html

## 💪 Challenge Projects

Once comfortable with LINQPad, try:

1. **Algorithm Comparison** - Load multiple sorting algorithms, compare performance
2. **Visualize Recursion** - Print call stack for recursive algorithms
3. **Benchmark Suite** - Create a file that benchmarks 10 algorithms
4. **Interactive Explorer** - Load algorithms and let user choose inputs interactively
5. **Performance Tuning** - Find the fastest implementation of an algorithm

---

**Start with any `.linq` file and run it with Ctrl+Shift+Enter. Happy learning! 🚀**

