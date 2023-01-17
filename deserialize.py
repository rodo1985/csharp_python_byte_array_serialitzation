import numpy as np
from time import time

# set to false to disable print results
print_results = False

start = time()

# read byte array from file
byte_array_path = r'csharp_python_byte_array_serialitzation\csharp_python_byte_array_serialitzation\bin\Debug\byteArray.data'
with open(byte_array_path, 'rb') as f:
    # get data
    data = f.read()
    if print_results: print(data)

    # delete first 27 bytes and last byte
    data = data[27:len(data)-1]

    # convert data to uint numpy array
    data = np.frombuffer(data, dtype=np.uint8)
    
    if print_results: print(data)

    # plot execution time
    print(str((time() - start) * 1000) + ' ms')

