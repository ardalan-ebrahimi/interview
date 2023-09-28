import { Item } from "./Dummies";


function calculateTotalPrice(items: Item[]): number {
    let totalPrice = 0;
    for (let i = 0; i < items.length; i++) {
        if (items[i].price > 10) {
            totalPrice += items[i].price;
        }
    }
    for (let i = 0; i < items.length; i++) {
        if (items[i].price <= 10) {
            totalPrice += items[i].price;
        }
    }
    return totalPrice;
}
