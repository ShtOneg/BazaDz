void print(params int[] numbers) {
    for (int i = 0; i < numbers.Length; i++) {
        Console.WriteLine($"Номер {i} число {numbers[i]}");
    }
}

print(45, 7, 9, 5, 6, 33, 67, 8);