cmake_minimum_required(VERSION 3.8)
project(c)

set(CMAKE_CXX_STANDARD 11)

set(SOURCE_FILES library.cpp library.h mzencryptutil.cpp mzencryptutil_c.cpp)
add_library(c SHARED ${SOURCE_FILES})