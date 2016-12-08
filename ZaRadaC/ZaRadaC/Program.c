
#include <stdio.h>
#include <math.h>
//5
int main(void)
{
	int i;
	int j;
	int m;
	int n;
	int L;
	int K;
	int **a;
	int pom;

	printf("Dimenzije matrice?: ");
	scanf("%d%d", &m, &n);
	a= (int**)malloc(m*sizeof(int*));
	for (i = 0; i < m; ++i)
		a[i] = (int*)malloc(n*sizeof(int));

	printf("\nElementi matrice?: ");
	for (i = 0; i < m; i++)
		for (j = 0; j < n; j++)
			scanf("%d", &a[i][j]);

	printf("\nUnesite koje kolone zelite da zamenite (0-%d):", n - 1);
	scanf("%d%d", &L, &K);

	for (i = 0; i < m; i++)
		for (j = 0; j < n; j++)
		{
			if (j == L)
			{
				pom = a[i][L];
				a[i][L] = a[i][K];
				a[i][K] = pom;
			}
		}

	printf("Ispis obradjene matrice: \n");

	for (i = 0; i < m; i++)
	{
		for (j = 0; j < n; j++)
			printf("%d ", a[i][j]);
		printf("\n");
	}

	printf("Oslobadjanje prostora matrice: \n");
	for (i = 0; i < m; i++)
		free (a[i]);
	free(a);
	printf("Gotovo! \n");

	system("pause");

}