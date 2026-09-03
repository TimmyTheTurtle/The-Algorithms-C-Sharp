<Query Kind="Statements">
</Query>

// ============================================================================
// 100-LEVEL SORTING ALGORITHMS
// ============================================================================
// Interactive exploration of fundamental sorting algorithms
// Press Ctrl+Shift+Enter to run each section
// ============================================================================

"SORTING ALGORITHMS - 100 LEVEL".Dump("=== LEARNING GUIDE ===");

// Helper function for visualization
void PrintArray(int[] arr, string label = "Array") => 
    label.Dump($"[{string.Join(", ", arr)}]");

// ============================================================================
// 1. BUBBLE SORT
// ============================================================================
"1. BUBBLE SORT - Repeatedly step through and swap adjacent elements".Dump("Section");

int[] BubbleSort(int[] arr)
{
    int[] result = (int[])arr.Clone();
    int n = result.Length;
    
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (result[j] > result[j + 1])
            {
                // Swap
                int temp = result[j];
                result[j] = result[j + 1];
                result[j + 1] = temp;
            }
        }
    }
    
    return result;
}

// Bubble Sort with step-by-step visualization
"Bubble Sort Visualization:".Dump();

int[] testArr = { 5, 2, 8, 1, 9 };
$"Original: [{string.Join(", ", testArr)}]".Dump("Input");

var sorted = BubbleSort(testArr);
$"Sorted: [{string.Join(", ", sorted)}]".Dump("Output");

new 
{ 
    Algorithm = "Bubble Sort",
    TimeComplexity = "O(n²)",
    SpaceComplexity = "O(1)",
    Stable = "Yes",
    BestCase = "O(n) - already sorted",
    WorstCase = "O(n²) - reverse sorted"
}.Dump("Bubble Sort Analysis");

// ============================================================================
// 2. SELECTION SORT
// ============================================================================
"2. SELECTION SORT - Find minimum and move it to sorted portion".Dump("Section");

int[] SelectionSort(int[] arr)
{
    int[] result = (int[])arr.Clone();
    int n = result.Length;
    
    for (int i = 0; i < n - 1; i++)
    {
        // Find minimum in unsorted portion
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (result[j] < result[minIndex])
                minIndex = j;
        }
        
        // Swap with current position
        int temp = result[i];
        result[i] = result[minIndex];
        result[minIndex] = temp;
    }
    
    return result;
}

"Selection Sort Example:".Dump();
int[] testArr2 = { 64, 25, 12, 22, 11 };
$"Original: [{string.Join(", ", testArr2)}]".Dump("Input");

var sorted2 = SelectionSort(testArr2);
$"Sorted: [{string.Join(", ", sorted2)}]".Dump("Output");

new 
{ 
    Algorithm = "Selection Sort",
    TimeComplexity = "O(n²) - always",
    SpaceComplexity = "O(1)",
    Stable = "No",
    Advantage = "Minimal swaps - good when write operations are expensive",
    Use = "Small arrays or when memory writes are costly"
}.Dump("Selection Sort Analysis");

// ============================================================================
// 3. INSERTION SORT
// ============================================================================
"3. INSERTION SORT - Build sorted array one item at a time".Dump("Section");

int[] InsertionSort(int[] arr)
{
    int[] result = (int[])arr.Clone();
    
    for (int i = 1; i < result.Length; i++)
    {
        int key = result[i];
        int j = i - 1;
        
        // Shift elements greater than key to the right
        while (j >= 0 && result[j] > key)
        {
            result[j + 1] = result[j];
            j--;
        }
        
        // Insert key at correct position
        result[j + 1] = key;
    }
    
    return result;
}

"Insertion Sort Example:".Dump();
int[] testArr3 = { 5, 2, 8, 1, 9 };
$"Original: [{string.Join(", ", testArr3)}]".Dump("Input");

var sorted3 = InsertionSort(testArr3);
$"Sorted: [{string.Join(", ", sorted3)}]".Dump("Output");

new 
{ 
    Algorithm = "Insertion Sort",
    TimeComplexity = "O(n²)",
    SpaceComplexity = "O(1)",
    Stable = "Yes",
    BestCase = "O(n) - already sorted",
    WorstCase = "O(n²) - reverse sorted",
    Advantage = "Efficient for small arrays and nearly sorted data"
}.Dump("Insertion Sort Analysis");

// ============================================================================
// SORTING COMPARISON
// ============================================================================
"SORTING ALGORITHM COMPARISON".Dump("Section");

// Generate test arrays
int[] GenerateRandomArray(int size, int seed = 42)
{
    Random rand = new Random(seed);
    return Enumerable.Range(0, size).Select(_ => rand.Next(1000)).ToArray();
}

int[] GenerateSortedArray(int size) => Enumerable.Range(1, size).ToArray();
int[] GenerateReverseSortedArray(int size) => Enumerable.Range(1, size).Reverse().ToArray();

// Benchmark different arrays
"Performance on Random Data (100 elements):".Dump();
int[] randomData = GenerateRandomArray(100);

var bubbleSw = Stopwatch.StartNew();
BubbleSort(randomData);
bubbleSw.Stop();

var selectionSw = Stopwatch.StartNew();
SelectionSort(randomData);
selectionSw.Stop();

var insertionSw = Stopwatch.StartNew();
InsertionSort(randomData);
insertionSw.Stop();

new[] 
{
    new { Algorithm = "Bubble Sort", Time = $"{bubbleSw.ElapsedTicks} ticks" },
    new { Algorithm = "Selection Sort", Time = $"{selectionSw.ElapsedTicks} ticks" },
    new { Algorithm = "Insertion Sort", Time = $"{insertionSw.ElapsedTicks} ticks" }
}
.OrderBy(x => int.Parse(x.Time.Split(' ')[0]))
.Dump("Sorting Performance (smaller is faster)");

// ============================================================================
// 4. QUICKSORT (Preview)
// ============================================================================
"4. QUICKSORT PREVIEW - Divide and Conquer Approach".Dump("Section");

int[] QuickSort(int[] arr, int low = 0, int high = -1)
{
    if (high == -1) high = arr.Length - 1;
    int[] result = (int[])arr.Clone();
    
    void QuickSortHelper(int l, int h)
    {
        if (l < h)
        {
            int pi = Partition(l, h);
            QuickSortHelper(l, pi - 1);
            QuickSortHelper(pi + 1, h);
        }
    }
    
    int Partition(int l, int h)
    {
        int pivot = result[h];
        int i = l - 1;
        
        for (int j = l; j < h; j++)
        {
            if (result[j] < pivot)
            {
                i++;
                int temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
        }
        
        int temp2 = result[i + 1];
        result[i + 1] = result[h];
        result[h] = temp2;
        
        return i + 1;
    }
    
    QuickSortHelper(low, high);
    return result;
}

"QuickSort Example:".Dump();
int[] testArr4 = { 5, 2, 8, 1, 9, 3 };
$"Original: [{string.Join(", ", testArr4)}]".Dump("Input");

var sorted4 = QuickSort(testArr4);
$"Sorted: [{string.Join(", ", sorted4)}]".Dump("Output");

new 
{ 
    Algorithm = "QuickSort",
    TimeComplexity = "O(n log n) average, O(n²) worst",
    SpaceComplexity = "O(log n) - recursion stack",
    Stable = "No (standard version)",
    Advantage = "Very fast average case, used in production",
    Use = "General purpose sorting, large arrays"
}.Dump("QuickSort Analysis");

// ============================================================================
// 5. MERGE SORT PREVIEW
// ============================================================================
"5. MERGE SORT PREVIEW - Guaranteed O(n log n)".Dump("Section");

int[] MergeSort(int[] arr)
{
    if (arr.Length <= 1) return arr;
    
    int mid = arr.Length / 2;
    int[] left = MergeSort(arr.Take(mid).ToArray());
    int[] right = MergeSort(arr.Skip(mid).ToArray());
    
    return Merge(left, right);
}

int[] Merge(int[] left, int[] right)
{
    int[] result = new int[left.Length + right.Length];
    int i = 0, j = 0, k = 0;
    
    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            result[k++] = left[i++];
        else
            result[k++] = right[j++];
    }
    
    while (i < left.Length) result[k++] = left[i++];
    while (j < right.Length) result[k++] = right[j++];
    
    return result;
}

"MergeSort Example:".Dump();
int[] testArr5 = { 5, 2, 8, 1, 9 };
$"Original: [{string.Join(", ", testArr5)}]".Dump("Input");

var sorted5 = MergeSort(testArr5);
$"Sorted: [{string.Join(", ", sorted5)}]".Dump("Output");

new 
{ 
    Algorithm = "MergeSort",
    TimeComplexity = "O(n log n) - always",
    SpaceComplexity = "O(n) - requires extra array",
    Stable = "Yes",
    Advantage = "Guaranteed performance, stable, good for linked lists",
    Use = "When guaranteed O(n log n) is required"
}.Dump("MergeSort Analysis");

// ============================================================================
// ALGORITHM COMPARISON TABLE
// ============================================================================
"COMPLETE SORTING ALGORITHM COMPARISON".Dump("Summary");

new[] 
{
    new { Algorithm = "Bubble Sort", TimeAvg = "O(n²)", TimeBest = "O(n)", TimeWorst = "O(n²)", Space = "O(1)", Stable = "Yes" },
    new { Algorithm = "Selection Sort", TimeAvg = "O(n²)", TimeBest = "O(n²)", TimeWorst = "O(n²)", Space = "O(1)", Stable = "No" },
    new { Algorithm = "Insertion Sort", TimeAvg = "O(n²)", TimeBest = "O(n)", TimeWorst = "O(n²)", Space = "O(1)", Stable = "Yes" },
    new { Algorithm = "QuickSort", TimeAvg = "O(n log n)", TimeBest = "O(n log n)", TimeWorst = "O(n²)", Space = "O(log n)", Stable = "No" },
    new { Algorithm = "MergeSort", TimeAvg = "O(n log n)", TimeBest = "O(n log n)", TimeWorst = "O(n log n)", Space = "O(n)", Stable = "Yes" }
}
.Dump("Sorting Algorithm Properties");

// ============================================================================
// CHALLENGE PROBLEMS
// ============================================================================
"CHALLENGE PROBLEMS".Dump("=== TRY THESE ===");

"1. Implement an optimized Bubble Sort that stops early if sorted".Dump();
"2. Create a hybrid sort that uses Insertion Sort for small arrays".Dump();
"3. Sort strings alphabetically (case-insensitive)".Dump();
"4. Sort objects by multiple properties (e.g., by age, then by name)".Dump();
"5. Implement three-way partitioning for QuickSort (handles duplicates better)".Dump();

// ============================================================================
// LEARNING TIPS
// ============================================================================
"LEARNING TIPS".Dump("=== REMEMBER ===");
new[] 
{
    "✓ Elementary sorts (Bubble, Selection, Insertion) are O(n²) - ok for small data",
    "✓ Advanced sorts (Quick, Merge, Heap) are O(n log n) - necessary for large data",
    "✓ Stability matters: sorts that preserve relative order of equal elements",
    "✓ Space matters: in-place sorting (O(1) space) vs requiring extra arrays",
    "✓ Real-world: C#'s Sort() uses Introsort (Quick + Heap + Insertion hybrid)",
    "✓ Modify code and press Ctrl+Shift+Enter to test different arrays!"
}
.ForEach(tip => tip.Dump());
