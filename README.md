# BlazorWrongCS8619_Report

JB report: https://youtrack.jetbrains.com/issue/RIDER-114891

1. Create generic component with disable nullability and EventCallback<T> property (example: SomeFakeTestComponent)
2. Try handle nullability in function - we get CS8619
3. Tty handle as no nullable - we get CS8602
4. <SomeClass?> cannot be used:  `The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.`

Wrong validation example
![image](https://github.com/user-attachments/assets/4119b2c3-0077-4266-ba0e-a6167cf68f18)

