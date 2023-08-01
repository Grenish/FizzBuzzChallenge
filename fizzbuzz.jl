function fizzbuzz(n::Int)
    for i in 1:n
        if i % 3 == 0 && i % 5 == 0
            println("FizzBuzz")
        elseif i % 3 == 0
            println("Fizz")
        elseif i % 5 == 0
            println("Buzz")
        else
            println(i)
        end
    end
end

# Test the function for numbers from 1 to 20
fizzbuzz(20)