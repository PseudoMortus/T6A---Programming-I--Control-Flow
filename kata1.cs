// Kata 1: Print the first 10 even numbers
// Step 1: write the first 20 numbers
// ** OBJECTIVE** Create your own loop using the following logic**
// Commit 1: "scaffold loop structure"
// Commit 2: "added even number condition"
// Commit 3: "refactored variable names for clarity"

for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
