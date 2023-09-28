import { User } from "./Dummies";
import { Product } from "./Dummies";

function getDiscountedPrice(product: Product, user: User, isPremiumMember: boolean): number {
    let discount = 0;

    if (product.category === 'Electronics') {
        if (user.age >= 18 && user.age <= 24) {
            if (isPremiumMember) {
                discount = 0.2; // 20% discount for young premium members on electronics
            } else {
                discount = 0.1; // 10% discount for young non-premium members on electronics
            }
        } else {
            if (isPremiumMember) {
                discount = 0.15; // 15% discount for premium members on electronics
            } else {
                discount = 0.05; // 5% discount for non-premium members on electronics
            }
        }
    } else {
        if (user.age >= 18 && user.age <= 24) {
            if (isPremiumMember) {
                discount = 0.1; // 10% discount for young premium members on non-electronics
            } else {
                discount = 0.05; // 5% discount for young non-premium members on non-electronics
            }
        } else {
            if (isPremiumMember) {
                discount = 0.05; // 5% discount for premium members on non-electronics
            } else {
                discount = 0; // No discount for non-premium members on non-electronics
            }
        }
    }

    return product.price - product.price * discount;
}
