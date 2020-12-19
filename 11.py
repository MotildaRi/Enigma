1 тип:
from math import log, ceil
n = int(input('Введите кол-во символов в пароле '))
s = int(input('Введите кол-во используемых символов для записи пароля '))
kol = int(input('Введите кол-во паролей '))
print(ceil((ceil(log(s, 2)) * n) / 8) * kol)
2 тип:
from math import ceil, log
n = int(input("Кол-во символов в пароле "))
s = int(input("Кол-во возможных символов "))
dop = int(input("Сколько занимают доп данные в байтах "))
kol = int(input("Кол-во поролей "))
print((ceil(ceil(log(s, 2)) * n / 8) + dop) * kol)
