<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
</Query>

// ============================================================================
// 100-LEVEL NUMERIC ALGORITHMS
// ============================================================================
// Interactive exploration of fundamental numeric algorithms
// Press Ctrl+Shift+Enter to run each section
// ============================================================================

"NUMERIC ALGORITHMS - 100 LEVEL".Dump("=== LEARNING GUIDE ===");

// ============================================================================
// 1. FACTORIAL
// ============================================================================
"1. FACTORIAL - Multiply all integers from 1 to n".Dump("Section");

// Recursive implementation
decimal RecursiveFactorial(int n)
{
    if (n <= 1) return 1;
    return n * RecursiveFactorial(n - 1);
}

// Iterative implementation
decimal IterativeFactorial(int n)
{
    decimal result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

// Test cases
"Factorial Examples:".Dump();
Enumerable.Range(0, 13)
    .Select(n => new 
    { 
        n, 
        Factorial = IterativeFactorial(n),
        Formula = $"{n}! = {(n == 0 ? "1" : $"1 × 2 × 3 ... × {n}")}"
    })
    .Dump("Factorial Values (0! to 12!)");

// Edge case: Large factorials (BigInteger handles huge numbers)
"Big Factorial:".Dump();
BigInteger BigFactorial(int n)
{
    BigInteger result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

new { Input = 100, Result = $"{BigFactorial(100).ToString().Length} digits" }
    .Dump("100! has this many digits");

// ============================================================================
// 2. FIBONACCI SEQUENCE
// ============================================================================
"2. FIBONACCI - Each number is sum of the two before it".Dump("Section");

// Naive recursive (slow - demonstrates exponential time)
int FibRecursive(int n)
{
    if (n <= 1) return n;
    return FibRecursive(n - 1) + FibRecursive(n - 2);
}

// Iterative (efficient - linear time)
int FibIterative(int n)
{
    if (n <= 1) return n;
    int prev = 0, curr = 1;
    for (int i = 2; i <= n; i++)
    {
        int next = prev + curr;
        prev = curr;
        curr = next;
    }
    return curr;
}

// Generate Fibonacci sequence
"Fibonacci Sequence:".Dump();
Enumerable.Range(0, 15)
    .Select(n => new 
    { 
        Position = n, 
        Value = FibIterative(n),
        Explanation = n == 0 ? "Start" : n == 1 ? "Start" : $"F({n-1}) + F({n-2})"
    })
    .Dump("First 15 Fibonacci Numbers");

// Performance comparison
"Performance Comparison:".Dump();
var recursive35 = Stopwatch.StartNew();
var r35 = FibRecursive(35);  // This will take a moment
recursive35.Stop();

var iterative35 = Stopwatch.StartNew();
var i35 = FibIterative(35);
iterative35.Stop();

new 
{ 
    Method = "Recursive", 
    Value = r35, 
    Time = $"{recursive35.ElapsedMilliseconds}ms",
    Complexity = "O(2^n) - exponential"
}.Dump();

new 
{ 
    Method = "Iterative", 
    Value = i35, 
    Time = $"{iterative35.ElapsedMilliseconds}ms",
    Complexity = "O(n) - linear"
}.Dump();

// ============================================================================
// 3. GREATEST COMMON DIVISOR (GCD)
// ============================================================================
"3. GCD - Largest number that divides both values".Dump("Section");

// Euclidean algorithm
int GCD(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

// Test cases
"GCD Examples:".Dump();
var gcdTests = new[] 
{ 
    (48, 18),
    (100, 50),
    (17, 19),
    (1071, 462),
};

gcdTests
    .Select(pair => new 
    { 
        A = pair.Item1, 
        B = pair.Item2, 
        GCD = GCD(pair.Item1, pair.Item2),
        Explanation = pair.Item1 == 48 && pair.Item2 == 18 ? "48=2³×3, 18=2×3², so GCD=6" : ""
    })
    .Dump("GCD Test Cases");

// ============================================================================
// 4. PRIME NUMBER CHECK
// ============================================================================
"4. PRIME NUMBERS - Numbers only divisible by 1 and themselves".Dump("Section");

bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    
    for (int i = 3; i * i <= n; i += 2)
        if (n % i == 0) return false;
    
    return true;
}

// Find primes in range
"Prime Numbers from 1-100:".Dump();
Enumerable.Range(1, 100)
    .Where(IsPrime)
    .Select(p => new { Prime = p })
    .Dump("There are 25 primes less than 100");

// ============================================================================
// 5. POWER AND MODULAR EXPONENTIATION
// ============================================================================
"5. MODULAR EXPONENTIATION - (base^exp) mod n".Dump("Section");

// Efficient modular exponentiation (used in cryptography)
BigInteger ModPow(BigInteger baseNum, BigInteger exponent, BigInteger modulus)
{
    BigInteger result = 1;
    baseNum = baseNum % modulus;
    
    while (exponent > 0)
    {
        if (exponent % 2 == 1)
            result = (result * baseNum) % modulus;
        
        exponent = exponent >> 1;
        baseNum = (baseNum * baseNum) % modulus;
    }
    
    return result;
}

"Modular Exponentiation Examples:".Dump();
new 
{ 
    Expression = "2^10 mod 1000",
    Result = ModPow(2, 10, 1000),
    Application = "Cryptography, hash functions"
}.Dump();

new 
{ 
    Expression = "3^100 mod 7",
    Result = ModPow(3, 100, 7),
    Explanation = "Used in modular arithmetic and number theory"
}.Dump();

// ============================================================================
// CHALLENGE PROBLEMS
// ============================================================================
"CHALLENGE PROBLEMS".Dump("=== TRY THESE ===");

"1. Implement factorial using memoization for better performance".Dump();
"2. Find all perfect numbers (where sum of divisors = number)".Dump();
"3. Implement binary exponentiation without modulo".Dump();
"4. Create a function to find LCM using GCD".Dump();
"5. Sieve of Eratosthenes - find all primes up to N".Dump();

// ============================================================================
// LEARNING TIPS
// ============================================================================
"LEARNING TIPS".Dump("=== REMEMBER ===");
new[] 
{
    "✓ Modify the code above and press Ctrl+Shift+Enter to re-run",
    "✓ Try different inputs: larger numbers, negative numbers, edge cases",
    "✓ Watch performance: compare iterative vs recursive approaches",
    "✓ Understand time complexity: O(1), O(log n), O(n), O(n²), O(2^n)",
    "✓ These algorithms are foundations for more complex ones"
}
.ForEach(tip => tip.Dump());
