from pyspark.shell import *

def products_merge(categories, products):
  products_categories_data = [("", "")]
  products_categories_schema = ["one", "two"]
  products_categories = spark.createDataFrame(products_categories_data, products_categories_schema)
  products_categories = products.join(categories, products.categories_id == categories.categories_id, "left") \
    .select("products", "categories")
  return products_categories

