<Query Kind="Statements">
</Query>

// ============================================================================
// 100-LEVEL STRING ALGORITHMS
// ============================================================================
// Interactive exploration of fundamental string algorithms
// Press Ctrl+Shift+Enter to run each section
// ============================================================================

"STRING ALGORITHMS - 100 LEVEL".Dump("=== LEARNING GUIDE ===");

// ============================================================================
// 1. STRING REVERSAL
// ============================================================================
"1. STRING REVERSAL - Read a string backwards".Dump("Section");

// Method 1: Using built-in
string ReverseBuiltin(string s) => new string(s.Reverse().ToArray());

// Method 2: Manual loop
string ReverseManual(string s)
{
    char[] chars = s.ToCharArray();
    int left = 0, right = chars.Length - 1;
    
    while (left < right)
    {
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;
        left++;
        right--;
    }
    
    return new string(chars);
}

// Test cases
"String Reversal Examples:".Dump();
var stringTests = new[] { "hello", "racecar", "LINQPad", "12345", "" };

stringTests
    .Select(s => new 
    { 
        Original = s, 
        Reversed = ReverseManual(s),
        IsPalindrome = s == ReverseManual(s) ? "Yes ✓" : "No"
    })
    .Dump("Reversal Test Cases");

// ============================================================================
// 2. PALINDROME CHECK
// ============================================================================
"2. PALINDROME - Words/phrases that read the same forwards and backwards".Dump("Section");

bool IsPalindrome(string s)
{
    // Remove non-alphanumeric and convert to lowercase
    string cleaned = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    
    // Compare with reverse
    return cleaned == new string(cleaned.Reverse().ToArray());
}

// Test cases
"Palindrome Examples:".Dump();
var palindromeTests = new[] 
{ 
    "racecar",
    "hello",
    "A man, a plan, a canal: Panama",
    "Was it a car or a cat I saw?",
    "12321",
    "hello world"
};

palindromeTests
    .Select(s => new 
    { 
        Text = s,
        CleanedVersion = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower(),
        IsPalindrome = IsPalindrome(s) ? "✓ YES" : "✗ NO"
    })
    .Dump("Palindrome Test Cases");

// ============================================================================
// 3. CHARACTER FREQUENCY COUNT
// ============================================================================
"3. CHARACTER FREQUENCY - Count how many times each character appears".Dump("Section");

Dictionary<char, int> CharacterFrequency(string s)
{
    var frequency = new Dictionary<char, int>();
    
    foreach (char c in s.ToLower())
    {
        if (char.IsLetterOrDigit(c))
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
    }
    
    return frequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
}

// Test case
"Character Frequency Example:".Dump();
var text = "hello world";
var freq = CharacterFrequency(text);

freq
    .Select(kvp => new 
    { 
        Character = kvp.Key, 
        Count = kvp.Value,
        Percentage = $"{(kvp.Value * 100.0 / text.Length):F1}%"
    })
    .Dump($"Character Frequency in \"{text}\"");

// ============================================================================
// 4. STRING COMPARISON & ANAGRAMS
// ============================================================================
"4. ANAGRAMS - Same letters rearranged".Dump("Section");

bool AreAnagrams(string s1, string s2)
{
    // Sort characters and compare
    var sorted1 = new string(s1.ToLower().Where(char.IsLetter).OrderBy(c => c).ToArray());
    var sorted2 = new string(s2.ToLower().Where(char.IsLetter).OrderBy(c => c).ToArray());
    
    return sorted1 == sorted2;
}

// Test cases
"Anagram Examples:".Dump();
var anagramTests = new[] 
{ 
    ("listen", "silent"),
    ("hello", "world"),
    ("abc", "bca"),
    ("The Eyes", "They See"),
    ("dormitory", "dirty room")
};

anagramTests
    .Select(pair => new 
    { 
        String1 = pair.Item1, 
        String2 = pair.Item2,
        AreAnagrams = AreAnagrams(pair.Item1, pair.Item2) ? "✓ YES" : "✗ NO"
    })
    .Dump("Anagram Test Cases");

// ============================================================================
// 5. SIMPLE WORD SEARCH - Find if substring exists
// ============================================================================
"5. SUBSTRING SEARCH - Find text within text".Dump("Section");

// Built-in method
int IndexOfSubstring(string haystack, string needle)
{
    return haystack.IndexOf(needle, StringComparison.OrdinalIgnoreCase);
}

// Manual implementation (for learning)
int ManualIndexOf(string haystack, string needle)
{
    if (needle.Length > haystack.Length) return -1;
    
    for (int i = 0; i <= haystack.Length - needle.Length; i++)
    {
        bool match = true;
        for (int j = 0; j < needle.Length; j++)
        {
            if (char.ToLower(haystack[i + j]) != char.ToLower(needle[j]))
            {
                match = false;
                break;
            }
        }
        if (match) return i;
    }
    
    return -1;
}

// Test cases
"Substring Search Examples:".Dump();
var searchTests = new[] 
{ 
    ("The quick brown fox", "brown"),
    ("LINQPad is awesome", "PAD"),
    ("Learning C#", "xyz"),
    ("AAAA", "AA"),
};

searchTests
    .Select(pair => new 
    { 
        Text = pair.Item1,
        Search = pair.Item2,
        Index = ManualIndexOf(pair.Item1, pair.Item2),
        Found = ManualIndexOf(pair.Item1, pair.Item2) >= 0 ? "✓ YES" : "✗ NO"
    })
    .Dump("Substring Search Test Cases");

// ============================================================================
// 6. VOWEL & CONSONANT COUNT
// ============================================================================
"6. VOWEL & CONSONANT COUNT - Categorize characters".Dump("Section");

(int vowels, int consonants) CountVowelsConsonants(string s)
{
    int vowelCount = 0, consonantCount = 0;
    var vowelSet = "aeiouAEIOU";
    
    foreach (char c in s)
    {
        if (char.IsLetter(c))
        {
            if (vowelSet.Contains(c))
                vowelCount++;
            else
                consonantCount++;
        }
    }
    
    return (vowelCount, consonantCount);
}

// Test
"Vowel & Consonant Count:".Dump();
string testPhrase = "Learning algorithms is fun!";
var (v, c) = CountVowelsConsonants(testPhrase);

new 
{ 
    Text = testPhrase,
    Vowels = v,
    Consonants = c,
    Total = v + c,
    Ratio = $"{(v * 100.0 / (v + c)):F1}% vowels"
}.Dump();

// ============================================================================
// 7. CASE CONVERSION & TOGGLING
// ============================================================================
"7. CASE CONVERSION - Change letter casing".Dump("Section");

string ToggleCase(string s) => new string(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
string ToCamelCase(string s) => char.ToLower(s[0]) + s.Substring(1);
string ToPascalCase(string s) => char.ToUpper(s[0]) + s.Substring(1);

// Examples
"Case Conversion Examples:".Dump();
string example = "helloWorld";

new[]
{
    new { Conversion = "Original", Result = example },
    new { Conversion = "ToUpper", Result = example.ToUpper() },
    new { Conversion = "ToLower", Result = example.ToLower() },
    new { Conversion = "ToggleCase", Result = ToggleCase(example) },
    new { Conversion = "ToCamelCase", Result = ToCamelCase("HELLO_WORLD") },
    new { Conversion = "ToPascalCase", Result = ToPascalCase("hello_world") }
}
.Dump("Case Conversion Results");

// ============================================================================
// CHALLENGE PROBLEMS
// ============================================================================
"CHALLENGE PROBLEMS".Dump("=== TRY THESE ===");

"1. Implement a function to remove duplicate characters from a string".Dump();
"2. Find the longest substring without repeating characters".Dump();
"3. Implement string compression (e.g., 'aaa' -> 'a3')".Dump();
"4. Rotate a string (e.g., 'hello' rotated 2 is 'llohe')".Dump();
"5. Check if two strings are rotations of each other".Dump();

// ============================================================================
// LEARNING TIPS
// ============================================================================
"LEARNING TIPS".Dump("=== REMEMBER ===");
new[] 
{
    "✓ Strings are immutable in C# - operations create new strings",
    "✓ Use .ToLower() or .ToUpper() for case-insensitive comparisons",
    "✓ LINQ Where/OrderBy are powerful for string manipulation",
    "✓ Consider edge cases: empty strings, single characters, nulls",
    "✓ Time complexity matters: nested loops = O(n²) or worse!",
    "✓ Modify the code and press Ctrl+Shift+Enter to experiment"
}
.ForEach(tip => tip.Dump());
