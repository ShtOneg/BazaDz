using DZ_21_05_24;

Animal[] animals = { new Animal("Какое-то животное"), new Dog("Шарик"), new Cat("Мурзик"), new Parrot("Кеша")};

foreach (Animal animal in animals) {
    animal.Say();
}
