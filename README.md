
# Test Driven Talk

This project contains the examples for my test driven development presentation which can be found in the project's Documents folder.

The project is broken up into folders, each folder represents me adding a single test and refactoring. 
Each folder contains the entire implementation, e.g. there is 4 PriceCalculator objects, one for each folder.

## Example 1
Creates the PriceCalculator (as I kind of know I will need an object later).
It asserts that we round our prices down 5 cents for each sale, this is so someone buying the product online will get the same price as if someone came into the store.

## Example 2
So we are testing a simple business rule which is that ClubMembers get 10% off the purchase price.
In this test we need to add a Customer object and refactor the calculator's GetPrice() method.

## Example 3
This test assures that if a product is on sale that the sale price is applied.

## Example 4
At this point the ProductOnSaleTest() test in Example3 doesn't really address the business requirements as products are on sale for a limited period of time.

This is where it starts to get complex.

First off we need to interface out the current DateTime so we can effectively test it so we create a ICalendar interface and create a stub to return a specific day. Then we need to inject the calendar into the price calculator.
Products need to model having a Sale object, so lets add that to the product. 
Then let’s use some FluidExtension methods to help simplify the Assert in the test.

So this was pretty hairy and there is a lot going on, but at the end of the day the test still looks pretty simple.

