from tkinter.simpledialog import askstring
from tkinter import *
from tkinter import messagebox

top = Tk()
top.geometry("200x120")

def A():
    expr = askstring("Input", "Enter an integer or math expression")
    if expr is None:
        messagebox.showerror("Error", "No input received")
        return
    try:
        result = int(eval(expr))
        messagebox.showinfo("Success", f"You entered: {result}")
    except:
        messagebox.showerror("Error", "Invalid input. Please enter a valid integer or expression.")

B = Button(top, text="Math", command=A)
B.place(x=60, y=30)

exit_btn = Button(top, text="Exit", command=top.quit)
exit_btn.place(x=70, y=70)

top.title("Integer Input")
top.mainloop()
