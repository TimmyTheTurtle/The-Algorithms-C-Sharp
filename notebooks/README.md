# 📓 Interactive Algorithm Learning with Jupyter Notebooks

This directory contains **Jupyter notebooks** (.ipynb files) for hands-on algorithm exploration using the **.NET Interactive kernel** and C#.

## Quick Start

### 1. Install Prerequisites

You need three components:

**Option A: VS Code (Recommended)**
```bash
# 1. Install .NET SDK (if not already installed)
# Download from https://dotnet.microsoft.com/download

# 2. Install Jupyter
pip install jupyter

# 3. Install .NET Interactive kernel
dotnet interactive jupyter install

# 4. Install VS Code Jupyter extension
# In VS Code: Ctrl+Shift+X, search "Jupyter", install "Jupyter" by Microsoft
```

**Option B: Jupyter Lab/Notebook (Command-line)**
```bash
jupyter notebook     # Opens in browser
# or
jupyter lab         # Opens Jupyter Lab in browser
```

### 2. Open a Notebook

**In VS Code:**
- Click on any `.ipynb` file in the Explorer
- Notebooks open automatically with full Jupyter support

**In Browser:**
```bash
jupyter notebook notebooks/
```

### 3. Run Code Cells

| Action | Shortcut |
|--------|----------|
| Execute cell | `Shift + Enter` or `Ctrl + Enter` |
| Add cell below | `Ctrl + Shift + Enter` |
| Delete cell | `DD` (in command mode) |
| Toggle cell type | `Y` (code) or `M` (markdown) |

## Available Notebooks

### 100-Level (Fundamentals)
- **100-level-numeric.ipynb** - Factorial, Fibonacci, GCD, primes, modular exponentiation
- **100-level-strings.ipynb** - Reversal, palindromes, anagrams, character frequency
- **100-level-sorting.ipynb** - Bubble, selection, insertion, quicksort, mergesort

### 200-Level (Coming Soon)
- Data structures, search algorithms, graph basics

### 300-Level (Coming Soon)
- Advanced algorithms, dynamic programming

### 400-Level (Coming Soon)
- Complex optimization and specialized domains

---

## Notebook Structure

Each notebook follows this pattern:

1. **Markdown explanations** - Theory and algorithm overview
2. **C# code cells** - Full working implementations
3. **Test examples** - Small example runs
4. **Performance comparisons** - Timing and complexity analysis
5. **Challenge problems** - Exercises to deepen understanding
6. **Learning tips** - Key takeaways and patterns

---

## Tips for Using Notebooks

### Console Output
```csharp
Console.WriteLine("Standard output appears below the cell");
```

### Working with Collections
```csharp
var arr = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine($"Array: [{string.Join(\", \", arr)}]");
```

### Performance Testing
```csharp
var sw = System.Diagnostics.Stopwatch.StartNew();
// ... your code ...
sw.Stop();
Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}ms");
```

### Importing Namespaces
```csharp
using System.Linq;  // Available automatically in most notebooks
```

### Sharing Variables Between Cells
Variables defined in one cell are accessible in subsequent cells:
```csharp
// Cell 1
var result = 42;

// Cell 2 (can access result)
Console.WriteLine(result);
```

---

## Keyboard Shortcuts (VS Code Jupyter)

| Command | Shortcut |
|---------|----------|
| Run cell | `Shift + Enter` |
| Run all cells | `Ctrl + Shift + Alt + Enter` |
| Run cells above | `Ctrl + Shift + P` then "Run Cells Above" |
| Run cells below | `Ctrl + Shift + P` then "Run Cells Below" |
| Interrupt kernel | `Ctrl + I, I` |
| Restart kernel | `Ctrl + Shift + F10` |

---

## Troubleshooting

### "Kernel not found" error
```bash
# Reinstall .NET Interactive kernel
dotnet interactive jupyter install --force-install
```

### Cell output missing
- Try restarting the kernel (`Ctrl + Shift + F10`)
- Clear all outputs and re-run: `Ctrl + Shift + P` → "Clear All Outputs"

### Performance issues
- Keep notebook kernels clean: restart after heavy computation
- Split large notebooks into smaller files
- Use `.Take(n)` to limit data for testing

---

## Learning Path Recommendations

**Complete the path in this order:**
1. **100-level-numeric.ipynb** - Get comfortable with syntax and loops (1-2 hours)
2. **100-level-strings.ipynb** - Practice string manipulation (1-2 hours)
3. **100-level-sorting.ipynb** - Understand fundamental algorithms (2-3 hours)
4. **Then proceed to 200-level** - Build on fundamentals

---

## Resources

- [.NET Interactive Documentation](https://github.com/dotnet/interactive)
- [Jupyter Notebook Documentation](https://jupyter.org/documentation)
- [C# Fundamentals](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Algorithm Complexity Reference](../ALGORITHM_LEARNING_PLAN.md)

---

**Pro Tip:** Use notebooks for active learning. Don't just read—modify the code, break it, fix it. That's where real understanding comes from! 🚀


