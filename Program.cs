
using System.Text.RegularExpressions;
using RegularWord;


//zador94@mail.ru


string patternEmail = @"^[a-z0-9]+\@[a-z0-9]+\(rambler|mail|yandex|gmail\)\.[a-z]{2,6}\(ru|com|site|shop|xyz\)$";

StringAnalize stringAnalize = new StringAnalize(patternEmail);

stringAnalizeConsoleEmail.MatchStringToPattern(stringAnalize);