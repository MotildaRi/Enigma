1 ���:
from math import log, ceil
n = int(input('������� ���-�� �������� � ������ '))
s = int(input('������� ���-�� ������������ �������� ��� ������ ������ '))
kol = int(input('������� ���-�� ������� '))
print(ceil((ceil(log(s, 2)) * n) / 8) * kol)
2 ���:
from math import ceil, log
n = int(input("���-�� �������� � ������ "))
s = int(input("���-�� ��������� �������� "))
dop = int(input("������� �������� ��� ������ � ������ "))
kol = int(input("���-�� ������� "))
print((ceil(ceil(log(s, 2)) * n / 8) + dop) * kol)
