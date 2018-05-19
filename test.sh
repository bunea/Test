#!/usr/bin/env bash
# Tiny, little, one-liner to run tests with
# a path, otherwise `dotnet test` will try
# to run tests on every project in a solution

dotnet test tests/Test.UnitTests
