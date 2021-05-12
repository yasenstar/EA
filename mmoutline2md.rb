#!/usr/bin/env ruby

input = STDIN.read

input.gsub!(/^\=+\n ?(.*?)\n\=+/,"# \\1")
input.gsub!(/^-+\n\d+ (.*?)\n-+/,"## \\1")
input.gsub!(/^\d+\.\d+ (.*)/,"### \\1")
input.gsub!(/^\d+\.\d+\./,"@")
input.gsub!(/^@\d+ /,"- ")
input.gsub!(/^@\d+\.\d+ /,"\t- ")
input.gsub!(/^@\d+\.\d+\.\d+ /,"\t\t- ")
input.gsub!(/^@\d+\.\d+\.\d+\.\d+ /,"\t\t\t- ")

print input
