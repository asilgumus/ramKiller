def killRam():
    ram = []
    while True:
        ram.append(bytearray(10_000_000))  # 10 MB

print("app started")
killRam()