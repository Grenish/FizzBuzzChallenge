<?php

function fizzbuzz($n) {
    for ($i = 1; $i <= $n; $i++) {
        if ($i % 3 == 0 && $i % 5 == 0) {
            echo "FizzBuzz\n";
        } elseif ($i % 3 == 0) {
            echo "Fizz\n";
        } elseif ($i % 5 == 0) {
            echo "Buzz\n";
        } else {
            echo $i . "\n";
        }
    }
}

// Test the function for numbers from 1 to 20
fizzbuzz(20);
?>