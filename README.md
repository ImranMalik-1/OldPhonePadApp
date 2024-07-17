# OldPhonePad

**A C# application that simulates old-style phone keypad text input and converts it to readable text.**

Welcome to the **OldPhonePad** repository! This application simulates the functionality of an old mobile phone keypad, where each number corresponds to a set of letters. Users can input a series of numbers, spaces, asterisks (`*`), and a hash (`#`) to get the corresponding text message.

## 📜 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Implementation](#implementation)
  - [Class Diagram](#class-diagram)
  - [Keypad Mapping](#keypad-mapping)
  - [How It Works](#how-it-works)
- [Usage](#usage)
  - [Running the Application](#running-the-application)
  - [Examples](#examples)

## Overview

**OldPhonePad** is a C# console application that processes a string of numeric inputs to generate text messages as they would appear on an old mobile phone keypad. This application supports text conversion from numeric sequences and handles spaces, asterisks (`*`), and hash (`#`) characters.

## Features

- **Simulates Old Phone Keypad:** Converts numeric sequences to text based on the traditional phone keypad layout.
- **Input Validation:** Ensures valid inputs, processing only numbers, spaces, asterisks, and hash characters.
- **Handles Edge Cases:** Supports multiple consecutive digits, spaces, and the asterisk character for backspacing.

## Implementation

### Class Diagram

Here’s a class diagram illustrating the `OldPhonePad` class:

```
+---------------------------------+
| OldPhonePad |
+---------------------------------+
| - PhonePadMap: Dictionary<char, string> |
+---------------------------------+
| + ProcessInput(input: string): string |
| - GetCharacter(digit: char, count: int): char |
| + Main(args: string[]): void |
+---------------------------------+

```

### Keypad Mapping

The keypad is mapped as follows:

| Digit | Letters |
|-------|---------|
| 2     | ABC     |
| 3     | DEF     |
| 4     | GHI     |
| 5     | JKL     |
| 6     | MNO     |
| 7     | PQRS    |
| 8     | TUV     |
| 9     | WXYZ    |
| 0     | 0       |

Each number corresponds to a set of letters. Pressing a key multiple times cycles through the letters, and spaces are used to separate different sequences of key presses.

### How It Works

1. **Input Parsing:** Reads the input string and processes each character.
2. **Character Handling:**
   - **Digit:** Counts consecutive presses of the same key.
   - **Space:** Resets the press count and moves to the next sequence.
   - **Asterisk (`*`):** Removes the last character from the result.
   - **Hash (`#`):** Ends the input process.
3. **Result Construction:** Uses a dictionary to map digits to their corresponding letters and appends the correct letter based on the number of presses.
4. **Edge Cases:** Handles various edge cases such as invalid characters, continuous digits, and asterisks for backspacing.


### Usage

To get started, clone the repository to your local machine:

```
git clone https://github.com/ImranMalik-1/OldPhonePadApp.git
cd OldPhonePadApp

# Build the Project
# Before running the application, you need to build the project. Use the following command:
dotnet build

# Run the Application
# To run the application, execute the following command:

dotnet run
