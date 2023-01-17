import numpy as np
from time import time

# path to byte array file
byte_array_path = r'csharp_python_byte_array_serialitzation\csharp_python_byte_array_serialitzation\bin\Debug\byteArray.data'

# create a numpy array that containts center of a rectangle and widht and height
rect = np.array([150, 3000, 1500, 1200], dtype=np.float32)

start = time()

# serialize numpy array to byte array
byte_array = rect.tobytes()

# save byte array to file
with open(byte_array_path, 'wb') as f:
    f.write(byte_array)

# plot execution time
print(str((time() - start) * 1000) + ' ms')
