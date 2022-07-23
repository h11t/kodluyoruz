### [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

## root 7 dir.

1.adım: 5, 7 den küçüktür. 7 nin soluna gelir.

			    7
		       /
		      5

2.adım: 1, 7 den küçük sola gelir 5 ile karşılaştırılır. 1, 5'ten de küçüktür.	5'in soluna gelir.

				    7
			       /
			      5
			     /
			    1

3.adım: 8, 7 den büyüktür, sağına gelir.

				    7
			       / \
			      5	  8
			     /
			    1

4.adım: 3,7 den küçük ve 7'nin soluna gelir. 3, 5'ten de küçük bu yüzden soluna gelir.	3, 1'den büyüktür sağına gelir.

				    7
			       / \
			      5	  8
			     /
			    1
			     \
			      3

5.adım: 6,7 den küçük ve 7'nin soluna gelir. 6, 5'ten büyük bu yüzden sağına gelir.

				    7
			       / \
			      5	  8
			     / \
			    1   6
			     \
			      3

6.adım: 0,7 den küçük ve 7'nin soluna gelir. 0, 5'ten de küçük bu yüzden soluna gelir.	0, 1'den küçüktür soluna gelir.

				    7
			       / \
			      5	  8
			     / \
			    1   6
			   / \
			  0   3

7.adım:9, 7 den büyüktür, sağına gelir.9, 8'den de büyüktür sağına gelir.

				    7
			       / \
			      5	  8
			     / \   \
			    1   6   9
			   / \
			  0   3
              
8.adım: 4,7 den küçük ve 7'nin soluna gelir. 4, 5'ten de küçük bu yüzden soluna gelir.	4, 1'den büyüktür sağına gelir.4, 3'den büyüktür sağına gelir.

				    7
			       / \
			      5	  8
			     / \   \
			    1   6   9
			   / \
			  0   3
			       \
				    4

9.adım: 2,7 den küçük ve 7'nin soluna gelir. 2, 5'ten de küçük bu yüzden soluna gelir.	2, 1'den büyüktür sağına gelir. 2, 3'ten de küçük bu yüzden soluna gelir.

				    7
			       / \
			      5	  8
			     / \   \
			    1   6   9
			   / \
			  0   3
			     / \
			    2 	4
	
			       	