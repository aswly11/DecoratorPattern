using DecoratorPattern;

IShape Circle = new Circle();

IShape redCircle = new RedBorderDecorator(Circle);
redCircle.Draw();