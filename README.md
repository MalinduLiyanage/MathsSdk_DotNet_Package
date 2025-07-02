# Maths SDK

A simple .NET SDK providing basic mathematical operations.

## NuGet Reference

```csharp
dotnet add package MalinduLiyanage.MathsSdk --version 1.0.0
```

## Package Info

| Property         | Value                    |
| ---------------- | ------------------------ |
| Target Framework | .NET 8.0                 |
| Package ID       | MalinduLiyanage.MathsSdk |
| Version          | 1.0.0                    |
| Author           | Malindu Liyanage         |
| Product          | Maths SDK                |

---

## Calculator Class

Provides basic arithmetic and advanced mathematical operations.

### Usage Example

```csharp
var calculator = new Calculator();

int sum = calculator.Add(3, 5);          // 8
int diff = calculator.Subtract(10, 4);   // 6
int product = calculator.Multiply(7, 6); // 42
double quotient = calculator.Divide(10, 2); // 5.0
double power = calculator.Power(2, 3);   // 8.0
double root = calculator.SquareRoot(16); // 4.0
long fact = calculator.Factorial(5);     // 120
```

---

### Methods

#### `int Add(int a, int b)`

Returns the sum of two integers.

* **Parameters:**

  * `a`: First integer.
  * `b`: Second integer.
* **Returns:** Sum of `a` and `b`.

---

#### `int Subtract(int a, int b)`

Returns the difference between two integers (`a - b`).

* **Parameters:**

  * `a`: First integer.
  * `b`: Second integer.
* **Returns:** Result of `a - b`.

---

#### `int Multiply(int a, int b)`

Returns the product of two integers.

* **Parameters:**

  * `a`: First integer.
  * `b`: Second integer.
* **Returns:** Product of `a` and `b`.

---

#### `double Divide(double a, double b)`

Returns the quotient of two doubles (`a / b`).

* **Parameters:**

  * `a`: Numerator.
  * `b`: Denominator.
* **Returns:** Result of division.
* **Throws:** `DivideByZeroException` if `b` is zero.

---

#### `double Power(double a, double b)`

Calculates `a` raised to the power of `b`.

* **Parameters:**

  * `a`: Base.
  * `b`: Exponent.
* **Returns:** `a` to the power of `b`.

---

#### `double SquareRoot(double a)`

Calculates the square root of a number.

* **Parameters:**

  * `a`: Number to find the square root of.
* **Returns:** Square root of `a`.
* **Throws:** `ArgumentException` if `a` is negative.

---

#### `long Factorial(int n)`

Calculates the factorial of a non-negative integer `n`.

* **Parameters:**

  * `n`: Number to calculate factorial for.
* **Returns:** Factorial of `n`.
* **Throws:** `ArgumentException` if `n` is negative.
