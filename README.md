# oop-encapsulation

## Encapsulation is an Object-Oriented Programming concept in which data and methods
are wrapped into a single unit called a class. It helps in data hiding by restricting
direct access to variables and allowing access through public methods

### Why it matters
- Keeps implementation details hidden while exposing a minimal interface.
- Helps maintain invariants by funneling access through controlled setters/getters.
- Encourages modular design so changes in one class have limited ripple effects.

### Common techniques
- Declare fields as `private` or `protected`, then expose `public` getters/setters.
- Use constructor validation to keep the object in a valid state from creation.
- Combine related behavior with the state it manipulates to avoid global state leaks.

### Material from the repo
- `Student` demonstrates hiding the `name` field and exposing `SetName`/`GetName` so external code cannot mutate the field directly.
- `Account` uses a `Balance` property that wraps a private `balance` field, allowing controlled reads/writes.
- `Employee` keeps `salary` private but provides setter and getter methods so other code can set or read the value only through the class interface.

