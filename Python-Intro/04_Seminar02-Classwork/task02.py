# Для натурального n создать словарь индекс-значение,
# состоящий из элементов последовательности 3n + 1.

n = int(input('Введите n: '))
# n_dict = {}
# for i in range(1, n + 1):
#     n_dict[i] = 3 * i + 1
n_dict = {i: 3 * i + 1 for i in range(1, n + 1)}  # Сокращенная запись
print(n_dict)