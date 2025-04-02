# Easy calculator (fixed version)

def calculator():
    print("Simple calculator: use +, -, *, /, **. Type 'help' for info or 'exit' to quit.")
    Running = True
    while Running:
        user_input = input(">>> ").strip().lower()
        
        if user_input == "exit":
            print("Exiting calculator.")
            Running = False
            
        elif user_input == "help":
            print("This is a simple calculator. You can use +, -, *, /, and ** for power.")
            continue
        
        try:
            result = eval(user_input, {"__builtins__": None}, {})
            print(result)
        except Exception:
            print("Error: Invalid input. Use proper mathematical expressions.")


# This code is a simple calculator that allows the user to perform basic arithmetic operations.
# It uses eval to evaluate the expression entered by the user.
# The calculator handles errors and provides a help message.
# Note: Using eval can be dangerous if not properly sanitized, as it can execute arbitrary code.
# In a production environment, consider using a safer alternative for evaluating expressions.
# This code is for educational purposes and should be used with caution.
#this canculator uses a safer limiting version of eval to prevent code injection attacks called __builtins__

