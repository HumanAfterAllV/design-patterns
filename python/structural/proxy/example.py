from proxy.proxy import ProxyDocument

def main():
    proxy = ProxyDocument("Patients.pdf", ["doctor", "admin"])

    try:
        proxy.display("Admin")
    except PermissionError as e:
        print(e)
    print("*------*")

    try:
        proxy.display("User")  
    except PermissionError as e:
        print(e)
    print("*------*")

    try:
        proxy.display("Dr.House") 
    except PermissionError as e:
        print(e)
    print("*------*")

if __name__ == "__main__":
    main()
