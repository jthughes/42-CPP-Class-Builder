# 42 C++ Class Builder
The C++ modules that are part of the 42 Common Core do not have the same strict coding style as set for the C projects, however there are still a number of requirements
Most particularly, unless otherwise stated, all classes must conform to Orthodox Canonical Form, requiring that there must be a explicitly defined:
- Default Constructor ``Example()``
- Copy Constructor ``Example(Example& instance)``
- Copy Assignment Operator overload ``Example& overload=(Example &instance)``
- Deconstructor ``~Example()``

This adds a lot of boilerplate which ultimately looks almost the same in different classes. The key pieces that change are the class name, and the names and types of the class properties to be managed by the above constructors.

The goal of this project is reduce the repetitive task of writing the initial class layouts for the paired .hpp and .cpp, by providing options to fill in some of the basic parts of most classes.
Given the large variety of different inputs, little to no validation is done on the input, leaving it to the user to ensure all values are entered correctly.
