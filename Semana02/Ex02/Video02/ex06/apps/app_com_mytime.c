#include "float_vector.h"
#include <stdio.h>
#include "mytime.h"

int main() {
    FloatVector *vec = FloatVector_create(2);
    FloatVector_print(vec);

    timer t1 = tic();
    FloatVector_append(vec, 0.0);
    FloatVector_append(vec, 1.0);
    FloatVector_print(vec);

    FloatVector_destroy(&vec);
    timer t2 = tac();
    printf("tempo de processamento: %f\n", comptime(t1, t2));
    return 0;
}