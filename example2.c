void main() {
  int k = 56 + 1090; // объявляем целую переменную key
  int sum = 0; // начальное значение суммы равно 0
  double gh = 6.987;
  int j = k;
  for(int i=1; i<=k; i++) // цикл для переменной i от 1 до k с шагом 1
  {
    for(; j > 0; --j) sum = sum + i;
    j = j + (21 * 56) / sum + sum * 65;
  }
}