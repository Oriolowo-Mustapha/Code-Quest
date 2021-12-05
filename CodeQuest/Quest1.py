###1. Given five positive integers, find the minimum and maximum values that can be calculated by 
#  summing exactly four of the five integers. Then print the respective minimum and maximum  
# values as a single line of two space-separated long integers. 
# Example: 
# arr = {1, 3, 5, 7, 9} 
# The minimum sum is 1 + 3 + 5 + 7 + 9 
# The maximum sum is 3 + 5 + 7 + 9 
# The Function Prints the following  
# 16 , 24 ###

arr = [1, 3, 5, 7, 9]

arr.sort()
    # sort the number in the correct order
Ex = sum(arr[0:4]), sum(arr[1:])
    # to add all remaining numbers except 1
var = Ex
    # stores the variable Ex in var
print(var[0],"," ,var[1])
