## [16,21,11,8,12,22] -> Merge Sort

### Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

[16,21,11,8,12,22]

[16,21,11]	[8,12,22]

[16,21]	[11]	[8,12][22]

[16][21][11]	[8][12][22]

[16,21][11]	[8,12][22]

[11,16,21]	[8,12,22]

[8,11,12,16,21,22]

## Big-O gösterimini yazınız.

1.adım : n/2  n/2

2.adım : n/4  n/4 n/4 n/4

3.adım : n/8  n/8 n/8 n/8 n/8 n/8 n/8 n/8

.

.

n.adım :1 1 1 1 ....

n+1. adım : ...

.

.

n+k. adım : n/4  n/4 n/4 n/4

n+k+1. adım : n/2 n/2

n+k+2. adım : n

O(n*logn)

