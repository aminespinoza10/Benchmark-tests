import hashlib
import sys
import time

def get_md5_hash(input_str):
    return hashlib.md5(input_str.encode()).hexdigest().upper()

if len(sys.argv) < 2:
    raise ValueError("Primer argumento no es OPCIONAL")

iterations = int(sys.argv[1])

start = time.time_ns()

for i in range(iterations):
    input_str = 'a' * i
    hash_str = get_md5_hash(input_str)
    #print(hash_str)

end = time.time_ns()
elapsed_milliseconds = (end - start) / 1_000_000
print(elapsed_milliseconds)